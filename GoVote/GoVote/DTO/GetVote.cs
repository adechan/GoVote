using GoVote.Data;
using MediatR;
using System;
using System.Collections.Generic;

namespace GoVote.DTO
{
    public class GetVote : IRequest<Dictionary<string, Guid>>
    {
        public GetVote(Guid id1, Guid id2)
        {
            CandidateID = id1;
            CitizenID = id2;
        }
        public Guid CandidateID { get; }
        public Guid CitizenID { get; }
    }
}
