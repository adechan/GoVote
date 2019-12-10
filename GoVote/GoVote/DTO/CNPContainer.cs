using MediatR;
using GoVote.Data;
namespace GoVote.DTO
{
    public class CNPContainer : IRequest<Citizen>
    {
        public string CNP { get; set; }
    }
}
