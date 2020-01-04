using System;

namespace GoVote.Data
{
    public class CandidateSimple
    { 
        public CandidateSimple(Guid id, string firstName, string lastName)
        {
            ID = id;
            FirstName = firstName;
            LastName = lastName;
        }

        public CandidateSimple(Candidate candidate)
        {
            ID = candidate.ID;
            FirstName = candidate.FirstName;
            LastName = candidate.LastName;
        }

        public Guid ID { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
    }
}
