using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoVote.Data
{
    public class LoginTokenDatabaseContext : DbContext
    {
        public LoginTokenDatabaseContext(DbContextOptions<LoginTokenDatabaseContext> options) : base(options)
        {
        }

        async public Task<bool> IsLoggedIn( Guid tokenId)
        {
            var tokens = await this.LoginTokens.ToListAsync();

            tokens.Sort((t1, t2) => (t1.CreationDate + t1.ExpiresAfter).CompareTo(t2.CreationDate + t2.ExpiresAfter));

            var mostRecentToken = tokens.ElementAt(0);
            return !mostRecentToken.HasExpired();
        }

        public DbSet<LoginToken> LoginTokens { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LoginToken>(e =>
            {
                e.Property(t => t.CitizenID).IsRequired();
                e.Property(t => t.ID).IsRequired();
                e.Property(t => t.CreationDate).IsRequired();
                e.Property(t => t.ExpiresAfter).IsRequired();
            });

            var tokenValue = new Guid("68e0883b-cbd7-4338-b0d6-b513a57cf53b");
            var citizenId = new Guid("79923D83-A092-443B-8120-6E8466925ABC");

            // Seed Method
            modelBuilder.Entity<LoginToken>().HasData(
                LoginToken.Create(tokenValue, citizenId, DateTime.Now, new TimeSpan(1, 0, 0))
            );
  
        }
    }

}
