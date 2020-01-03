using Microsoft.EntityFrameworkCore;

namespace GoVote.Data
{
    public class PartyDatabaseContext : DbContext
    {
        public PartyDatabaseContext(DbContextOptions<PartyDatabaseContext> options) : base(options)
        {

        }

        public DbSet<Party> Parties { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Party>(e =>
            {
                e.Property(t => t.PartyName).IsRequired();
            });

            // Seed Method
            modelBuilder.Entity<Party>().HasData(
                Party.Create("Cool Cats Political Party"));
        }
    }
}
