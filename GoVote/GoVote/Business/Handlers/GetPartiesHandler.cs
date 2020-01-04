using GoVote.Data;
using GoVote.DTO;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace GoVote.Business.Handlers
{
    public class GetPartiesHandler : IRequestHandler<GetParties, List<Party>>
    {
        private readonly PartyDatabaseContext _context;

        public GetPartiesHandler(PartyDatabaseContext context)
        {
            _context = context;
        }
        public async Task<List<Party>> Handle(GetParties request, CancellationToken cancellationToken)
        {

            var parties = await _context.Parties.ToListAsync();
            return parties;
        }

    }
}
