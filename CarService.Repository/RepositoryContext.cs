using CarService.Model;
using Microsoft.EntityFrameworkCore;

namespace CarService.Repository
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options)
        {

        }

        public DbSet<WorkTime> WorkTimes { get; set; }
        public DbSet<Worker> Workers { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<ConfirmReservation> ConfirmReservations { get; set; }
    }
}
