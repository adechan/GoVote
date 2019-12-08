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
                City = city
            };
        }

        public Guid ID { get; private set; }

        public string CNP { get; private set; }

        public string LastName { get; private set; }

        public string FirstName { get; private set; }

        public string Sex { get; private set; }

        public string Address { get; private set; }

        public string County { get; private set; }

        public string City { get; private set; }

    }
}
