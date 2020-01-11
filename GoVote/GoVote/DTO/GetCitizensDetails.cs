using MediatR;
using System.Collections.Generic;

namespace GoVote.DTO
{
    public class GetCitizenDetails : IRequest<Dictionary<string, object>>
    {
        public GetCitizenDetails(string cnp)
        {
            CNP = cnp;
        }
        public string CNP { get; set; }
    }
}
