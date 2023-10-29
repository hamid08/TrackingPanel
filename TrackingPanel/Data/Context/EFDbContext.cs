using Microsoft.EntityFrameworkCore;
using TrackingPanel.Data.Entites;

namespace TrackingPanel.Data.Context
{
    public class EFDbContext : DbContext
    {
        public EFDbContext(DbContextOptions<EFDbContext> options) : base(options)
        {

        }

        public DbSet<VehicleTracking> vehicleTrackings { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Tracking> Trackings { get; set; }

    }
}
