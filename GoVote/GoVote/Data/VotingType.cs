using System;

namespace GoVote.Data
{
    public class VotingType
    {
        public static VotingType Create(string votingTypeName)
        {
            return new VotingType
            {
                VotingTypeID = Guid.NewGuid(),
                VotingTypeName = votingTypeName
            };
        }
        public Guid VotingTypeID { get; private set; }
        public string VotingTypeName { get; private set; }
    }
}
