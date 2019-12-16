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
    public class GetCandidatesHandler : IRequestHandler<GetCandidates, Dictionary<string, string>>
    {

        private readonly CandidateDatabaseContext _context;

        public GetCandidatesHandler(CandidateDatabaseContext context)
        {
            _context = context;
        }

        public async Task<Dictionary<string, string>> Handle(GetCandidates request, CancellationToken cancellationToken)
        {
            var candidates = await _context.Candidates.ToListAsync();
            var candidatesName = new Dictionary<string, string>();

            foreach (Candidate candidate in candidates)
            {
                string guid = candidate.ID.ToString();

                candidatesName.Add("ID", guid);
                candidatesName.Add("LastName", candidate.LastName);
                candidatesName.Add("FirstName", candidate.FirstName);
            }

            return candidatesName;
        }

    }
}
