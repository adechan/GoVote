using GoVote.Data;
using GoVote.DTO;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace GoVote.Business.Handlers
{
    public class GetCandidatesHandler : IRequestHandler<GetCandidates, List<Candidate>>
    {

        private readonly CandidateDatabaseContext _context;

        public GetCandidatesHandler(CandidateDatabaseContext context)
        {
            _context = context;
        }

        public async Task<List<Candidate>> Handle(GetCandidates request, CancellationToken cancellationToken)
        {
            var candiates = await _context.Candidates.ToListAsync();
            return candiates;
        }

    }
}
