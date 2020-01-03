using GoVote.Data;
using GoVote.DTO;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace GoVote.Business.Handlers
{
    public class GetCandidateHandler : IRequestHandler<GetCandidateDetail, Candidate>
    {

        private readonly CandidateDatabaseContext context;

        public GetCandidateHandler(CandidateDatabaseContext context)
        {
            this.context = context;
        }
        public async Task<Candidate> Handle(GetCandidateDetail request, CancellationToken cancellationToken)
        {
            var candidate = await context.Candidates.SingleOrDefaultAsync(c => c.ID == request.ID);
            if (candidate == null)
            {
                throw new Exception("Record doesn't exist");
            }
            return candidate;
        }
    }
}
