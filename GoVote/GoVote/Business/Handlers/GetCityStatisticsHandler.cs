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
    public class GetCityStatisticsHandler : IRequestHandler<GetCityStatistics, Dictionary<string, float>>
    {
        private readonly CitizenDatabaseContext _context;

        public GetCityStatisticsHandler(CitizenDatabaseContext context)
        {
            _context = context;
        }

        public async Task<Dictionary<string, float>> Handle(GetCityStatistics request, CancellationToken cancellationToken)
        {
            var citizens = await _context.Citizens.ToListAsync();
            var statistics = new Dictionary<string, float>();

            var citizensInCity = citizens.Where(c => c.City == request.City);

            statistics["maleVotes"] = citizensInCity.Where(c => c.VotedFor != new System.Guid("0") && c.Sex == "Male").Count();
            statistics["femaleVotes"] = citizensInCity.Where(c => c.VotedFor != new System.Guid("0") && c.Sex == "Female").Count();

            return statistics;
        }
    }
}
