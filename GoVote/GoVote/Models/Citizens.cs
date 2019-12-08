namespace VotingService.Models
{
    public class Citizens
    {
<<<<<<< HEAD
        public Guid ID { get; set; }
        private string CNP { get; set; }
        private string LastName { get; set; }
        private string FirstName { get; set; }
        private char Sex { get; set; }
        private string Address { get; set; }
        private string County { get; set; }
        private string City { get; set; }

        public Citizens(Guid id, long cnp, string lastname, string firstname, char sex, string address, string country, string city)
        {
            ID = id;
            CNP = cnp;
            LastName = lastname;
            FirstName = firstname;
            Sex = sex;
            Address = address;
            County = country;
            City = city;
        }
     }
}
