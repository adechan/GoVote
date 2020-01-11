using System.Threading;
using System.Threading.Tasks;
using MediatR;
using GoVote.Data;
using GoVote.DTO;
using System.Linq;
using System.Diagnostics;

namespace GoVote.Business.Handlers
{
    public class VotingHandler : IRequestHandler<GetVote, Citizen>
    {
        private readonly CitizenDatabaseContext _context;
        private readonly CandidateDatabaseContext _contextC;

        public VotingHandler(CitizenDatabaseContext context, CandidateDatabaseContext contextC)
        {
            _context = context;
            _contextC = contextC;
        }

        public async Task<Citizen> Handle(GetVote request, CancellationToken cancellationToken)
        {
            var citizen = _context.Citizens.SingleOrDefault(c => c.ID == request.CitizenID);
            var candidate = _contextC.Candidates.SingleOrDefault(c => c.ID == request.CandidateID);

            Debug.WriteLine("REQUEST Citizen ID " + request.CitizenID);
            Debug.WriteLine("REQUEST Candidate ID " + request.CandidateID);

            if (citizen != null && candidate != null && citizen.VotedFor == new System.Guid("00000000-0000-0000-0000-000000000000"))
            {
                citizen.Update(request.CandidateID);
                await _context.SaveChangesAsync(cancellationToken);
            }

            return citizen;
        }

    }
}
                    