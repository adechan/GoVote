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
    public class GetAge31_60StatisticsHandler : IRequestHandler<GetAge31_60Statistics, Dictionary<string, float>>
    {
        private readonly CitizenDatabaseContext _context;

        public GetAge31_60StatisticsHandler(CitizenDatabaseContext context)
        {
            _context = context;
        }

        public async Task<Dictionary<string, float>> Handle(GetAge31_60Statistics request, CancellationToken cancellationToken)
        {
            var citizens = await _context.Citizens.ToListAsync();
            var statistics = new Dictionary<string, float>();
            List<Citizen> listCitizen = new List<Citizen>();

            string genderS = "";
            string birthYear = "";

            foreach (Citizen citizen in citizens)
            {
                genderS = citizen.CNP.Substring(0, 1);
                birthYear = citizen.CNP.Substring(1, 2);

                List<string> birthYearList = new List<string>();
                for (int i = 60; i < 90; i++)
                {
                    int numberInt = i;
                    birthYearList.Add(i.ToString());
                }
                // 31 - 60 : 1989 - 1960
                if ((genderS == "1" || genderS == "2") && birthYearList.Contains(birthYear))
                {
                    listCitizen.Add(citizen);
                }
            }

            statistics["maleVotes"] = listCitizen.Where(c => c.VotedFor != new System.Guid("00000000-0000-0000-0000-000000000000") && c.Sex == "Male").Count();
            statistics["femaleVotes"] = listCitizen.Where(c => c.VotedFor != new System.Guid("00000000-0000-0000-0000-000000000000") && c.Sex == "Female").Count();

            return statistics;
        }
    }
}
