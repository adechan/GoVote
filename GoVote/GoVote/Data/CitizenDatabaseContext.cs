using Microsoft.EntityFrameworkCore;
using System;

namespace GoVote.Data
{
    public class CitizenDatabaseContext : DbContext
    {
        public CitizenDatabaseContext(DbContextOptions<CitizenDatabaseContext> options) : base(options)
        {

        }

        public DbSet<Citizen> Citizens { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Citizen>(e =>
            {
                e.Property(t => t.CNP).IsRequired();
                e.Property(t => t.LastName).IsRequired();
                e.Property(t => t.FirstName).IsRequired();
                e.Property(t => t.Sex).IsRequired();
                e.Property(t => t.Address).IsRequired();
                e.Property(t => t.County).IsRequired();
                e.Property(t => t.City).IsRequired();
                e.Property(t => t.VotedFor);
            });

            // Seed Method
            modelBuilder.Entity<Citizen>().HasData(
               Citizen.Create("6000611068050", "Rindasu", "Andreea", "Female", "Prelungirea Salciei nr 11", "Bacau", "Bacau", new Guid("3A727820-76A9-4AE6-A465-260EA87A56A0")));
        }

    }
}
