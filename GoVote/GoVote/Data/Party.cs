using System;

namespace GoVote.Data
{
    public class Party
    {
        public static Party Create(string partyName)
        {
            return new Party
            {
                PartyID = Guid.NewGuid(),
                PartyName = partyName
            };
        }

        public Guid PartyID { get; private set; }
        public string PartyName { get; private set; }

    }
}
