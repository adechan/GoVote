namespace VotingService.Models
{
    public class Party
    {
        public Guid PartyID { get; set; }
        public string PartyName { get; set; }

        public Party(Guid partyID, string partyname)
        {
            PartyID = partyID;
            PartyName = partyname;
        }
    }
}