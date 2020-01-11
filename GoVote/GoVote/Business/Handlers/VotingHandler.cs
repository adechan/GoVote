using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using GoVote.Data;
using GoVote.DTO;
using System.Linq;
using Microsoft.EntityFrameworkCore;

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
            var citizens = await _context.Citizens.ToListAsync();
            var candidates = await _context.Candidates.ToListAsync();
            var result = new Dictionary <string, Guid>();

            foreach(Citizen citizen in citizens) 
            {
                if(citizen.VotedFor == new System.Guid("00000000-0000-0000-0000-000000000000"))
                {
                    foreach()
                }
            }

            var citizen = _context.Citizens.SingleOrDefault(c => c.CNP == request.CNP);
            await _context.SaveChangesAsync(cancellationToken);

            LoginToken token = LoginToken.Create(citizen.ID);

            _login_context.LoginTokens.Add(token);
            await _login_context.SaveChangesAsync(cancellationToken);
            return new Dictionary<string, Guid>(citizen, token.Get());
        }

    }
}
                    