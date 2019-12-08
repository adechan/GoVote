using MediatR;

namespace GoVote.Data
{
    public class CNPContainer : IRequest<Citizen>
    {
        public string CNP { get; set; }
    }
}
