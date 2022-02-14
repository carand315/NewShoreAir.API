using Microsoft.EntityFrameworkCore;
using NewShoreAir.Business.Models;

namespace NewShoreAir.DataAccess.Common
{
    public class NewShoreAirContext : DbContext
    {
        public virtual DbSet<Flight> Flights { get; set; }
        public virtual DbSet<Transport> Transports { get; set; }
        public NewShoreAirContext(DbContextOptions<NewShoreAirContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.MappingDataBase();
        }
    }
}
