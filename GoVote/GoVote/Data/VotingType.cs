using System;

namespace GoVote.Data
{
    public class VotingType
    {
        public static VotingType Create(string votingTypeName, Guid candidateID)
        {
            return new VotingType
            {
                VotingTypeID = Guid.NewGuid(),
                VotingTypeName = votingTypeName,
                CandidateID = candidateID
            };
        }
        public Guid VotingTypeID { get; private set; }
        public Guid CandidateID { get; private set; }
        public string VotingTypeName { get; private set; }
    }
}
