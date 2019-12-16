using Microsoft.EntityFrameworkCore;
using System;

namespace GoVote.Data
{
    public class CandidateDatabaseContext : DbContext
    {
        public CandidateDatabaseContext(DbContextOptions<CandidateDatabaseContext> options) : base(options)
        {

        }

        public DbSet<Candidate> Candidates { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Candidate>(e =>
            {
                e.Property(t => t.LastName).IsRequired();
                e.Property(t => t.FirstName).IsRequired();
                e.Property(t => t.PartyID).IsRequired();
            });

            //Seed Method
            modelBuilder.Entity<Candidate>().HasData(
                Candidate.Create("Kitty", "Kat", new Guid("8C014A9D-C44B-42DA-8EEB-21EDEB756842")),
                Candidate.Create("Doggy", "Bobby", new Guid("8C014A9D-C44B-42DA-8EEB-21EDEB756842"))
            );
        }

    }
}
