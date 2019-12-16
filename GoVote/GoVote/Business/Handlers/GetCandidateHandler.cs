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
    public class GetCandidateHandler : IRequestHandler<GetCandidateDetail, Dictionary<string, string>>
    {

        private readonly CandidateDatabaseContext _context;
        private readonly PartyDatabaseContext _context_p;

        public GetCandidateHandler(CandidateDatabaseContext context, PartyDatabaseContext context_p)
        {
            _context = context;
            _context_p = context_p;
        }
        public async Task<Dictionary<string, string>> Handle(GetCandidateDetail request, CancellationToken cancellationToken)
        {
            var candidates = await _context.Candidates.ToListAsync();
            var parties = await _context_p.Parties.ToArrayAsync();

            var candidatesById = new Dictionary<string, string>();

            var partyName =
                from candidate in candidates
                join party in parties on candidate.ID equals party.PartyID
                select new { Candidate = candidate.ID, Party = party.PartyName };

            var partyNameList = partyName.ToList();


            foreach(Candidate candidate in candidates)
            {
                var guid = candidate.ID.ToString();
                candidatesById.Add("ID", guid);
                candidatesById.Add("LastName", candidate.LastName);
                candidatesById.Add("FirstName", candidate.FirstName);
                candidatesById.Add("Party", partyNameList.Where(p => p.Candidate == candidate.PartyID).ToString());
            }

            return candidatesById;
        }
    }
}
