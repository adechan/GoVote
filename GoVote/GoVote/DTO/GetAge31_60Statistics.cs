using MediatR;
using System.Collections.Generic;

namespace GoVote.DTO
{
    public class GetAge31_60Statistics : IRequest<Dictionary<string, float>>
    {
        public string CNP { get; set; }
    }
}
