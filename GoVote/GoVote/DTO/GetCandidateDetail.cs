using GoVote.Data;
using MediatR;
using System;
using System.Collections.Generic;

namespace GoVote.DTO
{
    public class GetCandidateDetail : IRequest<Dictionary<string, string>>
    {
        public GetCandidateDetail(Guid id)
        {
            ID = id;
        }
        public Guid ID { get; }
    }
}
