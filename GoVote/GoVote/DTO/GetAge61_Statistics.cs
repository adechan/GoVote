using MediatR;
using System.Collections.Generic;

namespace GoVote.DTO
{
    public class GetAge61_Statistics : IRequest<Dictionary<string, float>>
    {
        public string CNP { get; set; }
    }
}
