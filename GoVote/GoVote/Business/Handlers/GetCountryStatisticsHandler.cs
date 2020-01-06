using GoVote.Data;
using GoVote.DTO;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace GoVote.Business.Handlers
{
    public class GetCountryStatisticsHandler : IRequestHandler<GetCountryStatistics, Dictionary<string, float>>
    {
        private readonly CitizenDatabaseContext _context;

        public GetCountryStatisticsHandler(CitizenDatabaseContext context)
        {
            _context = context;
        }

        public async Task<Dictionary<string, float>> Handle(GetCountryStatistics request, CancellationToken cancellationToken)
        {
            var citizens = await _context.Citizens.ToListAsync();
            var statistics = new Dictionary<string, float>();

            statistics["maleVotes"] = citizens.FindAll(c => c.VotedFor != new System.Guid("00000000-0000-0000-0000-000000000000") && c.Sex == "Male").Count;
            statistics["femaleVotes"] = citizens.FindAll(c => c.VotedFor != new System.Guid("00000000-0000-0000-0000-000000000000") && c.Sex == "Female").Count;
            return statistics;
        }
    }
}
