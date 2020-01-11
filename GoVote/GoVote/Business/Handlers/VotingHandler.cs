using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using GoVote.Data;
using GoVote.DTO;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace GoVote.Business.Handlers
{
    public class VotingHandler : IRequestHandler<GetVote, Dictionary<string, Guid>>
    {
        private readonly CitizenDatabaseContext _context;
        private readonly CandidateDatabaseContext _contextC;

        public VotingHandler(CitizenDatabaseContext context, CandidateDatabaseContext contextC)
        {
            _context = context;
            _contextC = contextC;
        }

        public async Task<Dictionary<string, Guid>> Handle(GetVote request, CancellationToken cancellationToken)
        {
            /*var citizens = await _context.Citizens.ToListAsync();
            var candidates = await _contextC.Candidates.ToListAsync();
            var result = new Dictionary <string, Guid>();

            foreach(Citizen citizen in citizens) 
            {
                if (citizen.ID == request.CitizenID)
                {

                    if (citizen.VotedFor == new System.Guid("00000000-0000-0000-0000-000000000000"))
                    {
                        foreach (Candidate candidate in candidates)
                        {
                            if (candidate.ID == request.CandidateID)
                            {
                                _context.Citizens.Update(request.CandidateID);
                                await _context.SaveChangesAsync(cancellationToken);

                                result.Add("ID citizen", citizen.ID);
                                result.Add("ID candidate", candidate.ID);
                            }
                        }
                    }
                }
            }

            return result;*/

            var citizen = _context.Citizens.SingleOrDefault(c => c.ID == request.CitizenID);
            var candidate = _contextC.Candidates.SingleOrDefault(c => c.ID == request.CandidateID);


            var result = new Dictionary<string, Guid>();
            if (citizen.VotedFor == new System.Guid("00000000-0000-0000-0000-000000000000"))
            {
                citizen.Update(request.CandidateID);
                await _context.SaveChangesAsync(cancellationToken);

                result.Add("ID citizen", citizen.ID);
                result.Add("ID candidate", candidate.ID);

            }

            return result;

           
        }

    }
}
                    