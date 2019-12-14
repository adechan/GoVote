using System;

namespace VotingService.Models
{
    public class CitizenVoted
    {
        public Guid VoterID { get; set; }
        public Guid CandidateID { get; set; }
        public bool Voted { get; set; }

        public CitizenVoted(Guid voterID, Guid candidateID, bool voted)
        {
            VoterID = voterID;
            CandidateID = candidateID;
            Voted = voted;
        }
    }
}