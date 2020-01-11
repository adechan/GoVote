using GoVote.Data;
using MediatR;
using System.Collections.Generic;

namespace GoVote.DTO
{
    public class GetVote : IRequest<Dictionary<string, Guid>>
    {
        public GetVote(Guid id)
        {
            ID = id;
        }
        public Guid ID { get; }
    }
}
