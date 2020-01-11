using System;

namespace GoVote.Data
{
    public class Citizen
    {
        public static Citizen Create(string cnp, string lastName, string firstName, string sex, string address, string county, string city)
        {
            return new Citizen
            {
                ID = Guid.NewGuid(),
                CNP = cnp,
                LastName = lastName,
                FirstName = firstName,
                Sex = sex,
                Address = address,
                County = county,
                City = city,
                VotedFor = new Guid("00000000-0000-0000-0000-000000000000")
            };
        }

        public static Citizen Create(string cnp, string lastName, string firstName, string sex, string address, string county, string city, Guid votedFor)
        {
            return new Citizen
            {
                ID = Guid.NewGuid(),
                CNP = cnp,
                LastName = lastName,
                FirstName = firstName,
                Sex = sex,
                Address = address,
                County = county,
                City = city,
                VotedFor = votedFor
            };
        }

        public bool hasVoted()
        {
            return this.VotedFor != new Guid("00000000-0000-0000-0000-000000000000");
        }


        public void Update(Guid votedFor)
        {
            VotedFor = votedFor;
        }

        public Guid ID { get; private set; }

        public string CNP { get; private set; }

        public string LastName { get; private set; }

        public string FirstName { get; private set; }

        public string Sex { get; private set; }

        public string Address { get; private set; }

        public string County { get; private set; }

        public string City { get; private set; }
        public Guid VotedFor { get; private set; }

    }
}
