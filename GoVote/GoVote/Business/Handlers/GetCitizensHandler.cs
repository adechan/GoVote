using GoVote.Data;
using GoVote.DTO;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;

namespace GoVote.Business.Handlers
{
    public class GetCitizensHandler : IRequestHandler<GetCitizens, List<Citizen>>
    {

        private readonly CitizenDatabaseContext _context;

        public GetCitizensHandler(CitizenDatabaseContext context)
        {
            _context = context;
        }

        public async Task<List<Citizen>> Handle(GetCitizens request, CancellationToken cancellationToken)
        {
            var citizens = await _context.Citizens.ToListAsync();
            return citizens;
        }

    }
}
