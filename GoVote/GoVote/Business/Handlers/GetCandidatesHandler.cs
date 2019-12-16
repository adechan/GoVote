using GoVote.Data;
using GoVote.DTO;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace GoVote.Business.Handlers
{
    public class GetCandidatesHandler : IRequestHandler<GetCandidates, List<CandidateSimple>>
    {

        private readonly CandidateDatabaseContext _context;

        public GetCandidatesHandler(CandidateDatabaseContext context)
        {
            _context = context;
        }

        public async Task<List<CandidateSimple>> Handle(GetCandidates request, CancellationToken cancellationToken)
        {
            var candidates = await _context.Candidates.ToListAsync();
            List<CandidateSimple> simpleCandidates = new List<CandidateSimple>();

            foreach (Candidate candidate in candidates)
                simpleCandidates.Add(new CandidateSimple(candidate));

            return simpleCandidates;
        }

    }
}
