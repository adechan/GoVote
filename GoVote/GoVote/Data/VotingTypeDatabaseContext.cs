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
            });

            //Seed Method
            modelBuilder.Entity<VotingType>().HasData(
                VotingType.Create("Alegeri prezidentiale"),
                VotingType.Create("Alegeri parlamentare")
            );
        }
    }
}
