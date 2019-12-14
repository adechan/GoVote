using System.Threading;
using System.Threading.Tasks;
using MediatR;
using GoVote.Data;
using GoVote.DTO;
using System.Linq;

namespace GoVote.Business.Handlers
{
    public class LoginHandler : IRequestHandler<CNPContainer, Citizen>
    {
        private readonly CitizenDatabaseContext _context;

        public LoginHandler(CitizenDatabaseContext context)
        {
            _context = context;
        }


        public async Task<Citizen> Handle(CNPContainer request, CancellationToken cancellationToken)
        {
            var cnp = _context.Citizens.SingleOrDefault(c => c.CNP == request.CNP);
            await _context.SaveChangesAsync(cancellationToken);
            return cnp;
        }
    }
}
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 