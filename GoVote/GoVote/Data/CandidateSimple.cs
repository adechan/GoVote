using System;

namespace GoVote.Data
{
    public class CandidateSimple
    { 
        public CandidateSimple(Guid id, string firstName, string lastName)
        {
            this.ID = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public CandidateSimple(Candidate candidate)
        {
            this.ID = candidate.ID;
            this.FirstName = candidate.FirstName;
            this.LastName = candidate.LastName;
        }

        public Guid ID { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
    }
}
