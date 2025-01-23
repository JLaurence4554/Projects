using Microsoft.EntityFrameworkCore;

namespace WebApplication1.API.Models
{
    public class RentalDbContext : DbContext
    {
        public RentalDbContext(DbContextOptions<RentalDbContext> options) : base(options) { }
        public DbSet<costumer> costumers { get; set; }
        public DbSet<movie> movies { get; set; }
        public DbSet<RentalMovie> rentals { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<costumer>().HasKey(c => c.costumerID);
            modelBuilder.Entity<movie>().HasKey(m => m.movieID);
            modelBuilder.Entity<RentalMovie>().HasKey(r => r.RentalDuration);

            modelBuilder.Entity<RentalMovie>()
                .HasOne(e => e.costumerID)
                .WithMany(m => m.movieID)
                .HasForiegnKey( r => r.RentalMovie)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<RentalMovie>()
                .HasOne(e => e.costumerID)
                .WithMany(m => m.movieID)
                .HasForiegnKey(r => r.RentalMovie)
                .OnDelete(DeleteBehavior.Restrict);
        }

    }
}
