using GoVote.Data;
using GoVote.DTO;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace GoVote.Business.Handlers
{
    public class GetTop10CandidatesInCityStatisticsHandler : IRequestHandler<GetTop10CandidatesInCityStatistics, Dictionary<string, float>>
    {
        private readonly CandidateDatabaseContext _context_c;
        private readonly CitizenDatabaseContext _context;

        public GetTop10CandidatesInCityStatisticsHandler(CitizenDatabaseContext context, CandidateDatabaseContext context_c)
        {
            _context = context;
            _context_c = context_c;
        }
        public async Task<Dictionary<string, float>> Handle(GetTop10CandidatesInCityStatistics request, CancellationToken cancellationToken)
        {
            var citizens = await _context.Citizens.ToListAsync();
            var candidates = await _context_c.Candidates.ToArrayAsync();

            var statistics = new Dictionary<string, float>();

            var citizensInCity = citizens.Where(c => c.City == request.City);

            var candidateNameQuery =
               from citizen in citizens
               join candidate in candidates on citizen.VotedFor equals candidate.ID
               select new { Citizen = candidate.ID, Candidate = candidate.LastName + " " + candidate.FirstName };

            var candidateNameList = candidateNameQuery.ToList();

            foreach (Citizen citizen in citizensInCity)
            {
                if (!citizen.hasVoted())
                    continue;

                var candidate = candidateNameList.Where(c => c.Citizen == citizen.VotedFor).ElementAt(0);
                statistics[candidate.Candidate] += 1; 
            }

            var statisticsList = statistics.ToList();
            statisticsList.Sort((count1, count2) => count1.Value.CompareTo(count2.Value));

            var top10List = statisticsList.Take(1);
            return top10List.ToDictionary(x => x.Key, x => x.Value);

        }
    }
}
