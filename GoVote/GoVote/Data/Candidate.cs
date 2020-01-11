using System;

namespace GoVote.Data
{
    public class Candidate
    {
        public static Candidate Create(string lastName, string firstName, Guid partyId, Guid votingTypeId)
        {
            return new Candidate
            {
                ID = Guid.NewGuid(),
                LastName = lastName,
                FirstName = firstName,
                PartyID = partyId,
                VotingTypeId = votingTypeId
            };
        }

        public Guid ID { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public Guid PartyID { get; private set; }
        public Guid VotingTypeId { get; private set; }
    }
}
