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
    public class LoginHandler : IRequestHandler<CNPContainer, Tuple<Citizen, Guid>>
    {
        private readonly CitizenDatabaseContext _context;
        private readonly LoginTokenDatabaseContext _login_context;

        public LoginHandler(CitizenDatabaseContext context, LoginTokenDatabaseContext login_context)
        {
            _context = context;
            _login_context = login_context;
        }

        public async Task<Tuple<Citizen, Guid>> Handle(CNPContainer request, CancellationToken cancellationToken)
        {
            var citizen = _context.Citizens.SingleOrDefault(c => c.CNP == request.CNP);
            await _context.SaveChangesAsync(cancellationToken);

            LoginToken token = LoginToken.Create(citizen.ID);

            _login_context.LoginTokens.Add(token);
            await _login_context.SaveChangesAsync(cancellationToken);
            return new Tuple<Citizen, Guid>(citizen, token.Get());
        }

    }
}
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 