using GoVote.Data;
using GoVote.DTO;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace GoVote.Business.Handlers
{
    public class GetVotingTypesHandler : IRequestHandler<GetVotingTypes, List<VotingType>>
    {
        private readonly VotingTypeDatabaseContext _context;

        public GetVotingTypesHandler(VotingTypeDatabaseContext context)
        {
            _context = context;
        }
        public async Task<List<VotingType>> Handle(GetVotingTypes request, CancellationToken cancellationToken)
        { 
            var votingTypes = await _context.VotingTypes.ToListAsync();
            return votingTypes;
        }
    }
}
