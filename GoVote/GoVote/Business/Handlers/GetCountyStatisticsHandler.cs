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
    public class GetCountyStatisticsHandler : IRequestHandler<GetCountyStatistics, Dictionary<string, float>>
    {
        private readonly CitizenDatabaseContext _context;

        public GetCountyStatisticsHandler(CitizenDatabaseContext context)
        {
            _context = context;
        }

        public async Task<Dictionary<string, float>> Handle(GetCountyStatistics request, CancellationToken cancellationToken)
        {
            var citizens = await _context.Citizens.ToListAsync();
            var statistics = new Dictionary<string, float>();

            var citizensInCounty = citizens.Where(c => c.County == request.County);

            statistics["maleVotes"] = citizensInCounty.Where(c => c.VotedFor != new System.Guid("0") && c.Sex == "Male").Count();
            statistics["femaleVotes"] = citizensInCounty.Where(c => c.VotedFor != new System.Guid("0") && c.Sex == "Female").Count();

            return statistics;
        }
    }
}
