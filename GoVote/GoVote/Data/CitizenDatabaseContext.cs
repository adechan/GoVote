using Microsoft.EntityFrameworkCore;

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
            });

            // Seed Method
            modelBuilder.Entity<Citizen>().HasData(
                Citizen.Create("1234567891234", "MEOWt Lastname", "Cat Firstname", "Female", "Cat address", "Cat county", "Cat City"));
        }

    }
}
