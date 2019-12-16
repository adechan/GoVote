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
            var candidateRequest = _context.Candidates.SingleOrDefault(c => c.ID == request.ID);

            var parties = await _context_p.Parties.ToArrayAsync();

            var candidatesById = new Dictionary<string, string>();

            var partyName =
                from candidate in candidates
                join party in parties on candidate.PartyID equals party.PartyID
                select new { Candidate = candidate.ID, Party = party.PartyName };

            var partyNameList = partyName.ToList();

            string listString = "";
            foreach (var party in partyNameList)
                listString += party.Party + ", ";

            System.Diagnostics.Debug.WriteLine("partyNameList: " + listString);

            foreach (Candidate candidate in candidates)
            {
                if (candidate == candidateRequest)
                {
                    if (candidatesById.ContainsKey("ID"))
                        break;

                    var guid = candidate.ID.ToString();
                    candidatesById.Add("ID", guid);

                    foreach (var item in partyNameList.Where(p => p.Candidate == candidate.ID))
                    {
                        candidatesById.Add("Party", item.Party);
                        break;
                    }

                    candidatesById.Add("LastName", candidate.LastName);
                    candidatesById.Add("FirstName", candidate.FirstName);
                }
            }

            string listString2 = "";
            foreach (var id in candidatesById)
                listString2 += id.Key + ": " + id.Value + ", ";

            System.Diagnostics.Debug.WriteLine("Candidate: " + listString2);
            return candidatesById;
        }
    }
}
