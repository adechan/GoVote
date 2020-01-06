using System;

namespace GoVote.Data
{
    public class LoginToken
    {
        public static LoginToken Create(Guid guid, Guid citizenId, DateTime creation, TimeSpan expiresAfter)
        {
            return new LoginToken
            {
                ID = guid,
                CreationDate = creation,
                ExpiresAfter = expiresAfter,
                CitizenID = citizenId
            };
        }

        public static LoginToken Create(Guid guid, Guid citizenId, DateTime creation)
        {
            return Create(guid, citizenId, creation, new TimeSpan(1, 0, 0));
        }

        public static LoginToken Create(Guid guid, Guid citizenId)
        {
            return Create(guid, citizenId, DateTime.Now);
        }
        public static LoginToken Create(Guid citizenId)
        {
            return Create(Guid.NewGuid(), citizenId);
        }

        public bool HasExpired()
        {
            return DateTime.Now > (CreationDate + ExpiresAfter);
        }

        public Guid Get()
        {
            if (HasExpired())
                throw new InvalidOperationException("Cannot get expired token");

            return ID;
        }

        public Guid ID { get; private set; }
        public TimeSpan ExpiresAfter { get; private set; }
        public DateTime CreationDate { get; private set; }
        public Guid CitizenID { get; private set; }

    }
}
