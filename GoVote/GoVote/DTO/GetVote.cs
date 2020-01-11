using GoVote.Data;
using MediatR;
using System;
using System.Collections.Generic;

namespace GoVote.DTO
{
    public class GetVote : IRequest<Citizen>
    {
        public GetVote(Guid citizenID, Guid candidateID)
        {
            CitizenID = citizenID;
            CandidateID = candidateID;
        }
        public Guid CandidateID { get; private set; }
        public Guid CitizenID { get; private set; }
    }
}
