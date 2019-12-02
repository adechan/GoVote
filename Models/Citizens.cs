using System;
using System.ComponentModel.DataAnnotations;

namespace VotingService.Models
{
    public class Citizens
    {
        public class Citizens
        {
            public int ID { get; set; }

            public long CNP { get; set; }

            public string LastName { get; set; }

            public string FirstName { get; set; }

            public char Sex { get; set; }

            public string Address { get; set; }

            public string County { get; set; }

            public string City { get; set; }
        }
    }
}
