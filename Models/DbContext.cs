using Microsoft.EntityFrameworkCore;

namespace FinalProject.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TruckDriver>().HasKey(s => new {s.TruckID, s.DriverID});
    }

    public DbSet<Driver> Drivers {get; set;}
    public DbSet<Truck> Trucks {get; set;}
    public DbSet<TruckDriver> TruckDrivers {get; set;}
    public DbSet<Reefer> Reefers {get; set;}


}