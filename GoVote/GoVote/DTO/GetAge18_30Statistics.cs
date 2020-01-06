using MediatR;
using System;
using System.Collections.Generic;

namespace GoVote.DTO
{
    public class GetAge18_30Statistics : IRequest<Dictionary<string, float>>
    {
        public string CNP { get; set; }
        public Guid Token { get; set; }
    }
}
