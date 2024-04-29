using Microsoft.EntityFrameworkCore;
using webapi.Models;

namespace webapi;

public class TaxisContext : DbContext
{
    public DbSet<Trajectory> Trajectories { get; set; }
    public DbSet<Taxi> Taxis { get; set; }

    public TaxisContext(DbContextOptions<TaxisContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        List<Trajectory> trajectoriesInit = new List<Trajectory>();

        modelBuilder.Entity<Trajectory>(trajectory =>
        {
            trajectory.ToTable("Trajectory");

            trajectory.HasKey(p => p.Id);

            trajectory.Property(p => p.Date).IsRequired();

            trajectory.Property(p => p.Latitude);

            trajectory.Property(p => p.Longitude);

            trajectory.HasOne(t => t.Taxi)
                .WithMany(t => t.Trajectories)
                .HasForeignKey(t => t.TaxiId);

        });

        List<Taxi> taxisInit = new List<Taxi>();

        modelBuilder.Entity<Taxi>(taxi =>
        {
            taxi.ToTable("Taxis");
            taxi.HasKey(p => p.Id);
            taxi.Property(p => p.Plate);

        });
    }

}