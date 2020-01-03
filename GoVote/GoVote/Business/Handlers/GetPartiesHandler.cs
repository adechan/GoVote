using GoVote.Data;
using GoVote.DTO;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace GoVote.Business.Handlers
{
    public class GetPartiesHandler : IRequestHandler<GetParties, Dictionary<string, string>>
    {
        private readonly PartyDatabaseContext _context;

        public GetPartiesHandler(PartyDatabaseContext context)
        {
            _context = context;
        }
        public async Task<Dictionary<string, string>> Handle(GetParties request, CancellationToken cancellationToken)
        {

            var parties = await _context.Parties.ToListAsync();
            var partiesName = new Dictionary<string, string>();

            foreach (Party party in parties)
            {
                partiesName.Add("PartyName", party.PartyName);
            }

            return partiesName;
        }

    }
}
