using System;

namespace VotingService.Models
{
    public class Candidates
    {
        public Guid ID { get; set; }
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private Guid PartyID { get; set; }

        public Candidates(Guid id, string firstname, string lastname, Guid partyID)
        {
            ID = id;
            FirstName = firstname;
            LastName = lastname;
            PartyID = partyID;
        }
    }
}