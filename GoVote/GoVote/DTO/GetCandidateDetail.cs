using GoVote.Data;
using MediatR;
using System;

namespace GoVote.DTO
{
    public class GetCandidateDetail : IRequest<Candidate>
    {
        public GetCandidateDetail(Guid id)
        {
            ID = id;
        }
        public Guid ID { get; }
    }
}
