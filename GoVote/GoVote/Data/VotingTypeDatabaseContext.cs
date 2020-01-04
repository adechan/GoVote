using Microsoft.EntityFrameworkCore;
using System;

namespace GoVote.Data
{
    public class VotingTypeDatabaseContext : DbContext
    {
        public VotingTypeDatabaseContext(DbContextOptions<VotingTypeDatabaseContext> options) : base(options)
        {

        }
        public DbSet<VotingType> VotingTypes { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VotingType>(e =>
            {
                e.Property(t => t.VotingTypeName).IsRequired();
                e.Property(t => t.CandidateID).IsRequired();
            });

            //Seed Method
            modelBuilder.Entity<VotingType>().HasData(
                VotingType.Create("Alegeri prezidentiale", new Guid("9e1bd44b-eb0c-4758-96f7-582ef41997fe"))
            );
        }
    }
}
