using GoVote.Data;
using GoVote.DTO;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Data.SqlClient;

namespace GoVote.Business.Handlers
{
    public class GetVotingTypeHandler : IRequestHandler<GetVotingTypeDetails, Dictionary<string, Guid>>
    {

        private readonly VotingTypeDatabaseContext _context;
        private readonly CandidateDatabaseContext __context;

        public GetVotingTypeHandler(VotingTypeDatabaseContext context)
        {
            _context = context;
        }
        public async Task<Dictionary<string, Guid>> Handle(GetVotingTypeDetails request, CancellationToken cancellationToken)
        {
            //var types = await _context.VotingTypes.ToListAsync();
            /*var candidates = await __context.Candidates.ToListAsync();

            var result = from t in types
                         join c in candidates 
                         on t.CandidateID equals c.ID
                         select c.FirstName;*/
            //candidatesId.Add("Candidate name:", result.ToString());

            var candidatesId = new Dictionary<string, Guid>();
            var type = await _context.VotingTypes.SingleOrDefaultAsync(c => c.VotingTypeID == request.ID);
            //foreach (VotingType v in types)
            //{
                candidatesId.Add("Candidate Id", type.CandidateID);
            //}

            return candidatesId;
            // var type = await context.VotingTypes.SingleOrDefaultAsync(c => c.VotingTypeID == request.ID);
            /*if (type == null)
            {
                throw new Exception("Record doesn't exist");
            }
            return type;*/
        }
    }
}
