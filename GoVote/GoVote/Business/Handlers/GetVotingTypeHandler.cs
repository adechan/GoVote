using GoVote.Data;
using GoVote.DTO;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace GoVote.Business.Handlers
{
    public class GetVotingTypeHandler : IRequestHandler<GetVotingTypeDetails, List<Dictionary<string, string>>>
    {

        private readonly VotingTypeDatabaseContext _context;
        private readonly CandidateDatabaseContext _context_c;

        public GetVotingTypeHandler(VotingTypeDatabaseContext context, CandidateDatabaseContext context_c)
        {
            _context = context;
            _context_c = context_c;
        }

        public async Task<List<Dictionary<string, string>>> Handle(GetVotingTypeDetails request, CancellationToken cancellationToken)
        {
            var types = await _context.VotingTypes.ToListAsync();
            var votingTypeRequest = _context.VotingTypes.SingleOrDefault(c => c.VotingTypeID == request.ID);

            var candidates = await _context_c.Candidates.ToListAsync();
            
            var result = from type in types
                         join candidate in candidates on type.VotingTypeID equals candidate.VotingTypeId
                        select new { Voting = type.VotingTypeID, Firstname = candidate.FirstName, Lastname = candidate.LastName};
            
            var votingTypeById = new Dictionary<string, string>();
            var listOfVotingTypes = new List<Dictionary<string, string>>();

            var candidatesList = result.ToList();

            foreach (VotingType votingType in types)
            {
                if (votingType == votingTypeRequest)
                {
                    foreach (var item in candidatesList.Where(v => v.Voting == votingType.VotingTypeID))
                    {
                        votingTypeById.Add("First Name", item.Firstname);
                        votingTypeById.Add("Last Name", item.Lastname);
                        listOfVotingTypes.Add(votingTypeById);
                        votingTypeById = new Dictionary<string, string>();
                    }
                }
            }
            return listOfVotingTypes;
        }
    }
}
