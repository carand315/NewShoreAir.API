using Microsoft.EntityFrameworkCore;
using NewShoreAir.Business.Models;
using System;

namespace NewShoreAir.DataAccess.Common
{
    internal static class ConfigFluentAPI
    {

        public static void MappingDataBase(this ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<Journey>();

            MapTransport(modelBuilder);
            MapFlight(modelBuilder);
        }


        private static void MapFlight(ModelBuilder mb)
        {
            var flight = mb.Entity<Flight>();

            flight.ToTable("FLIGHTS");
            flight.HasKey(m => m.Id);

            flight.Property(p => p.Origin)
                .HasColumnName("Origin")
                .IsRequired();

            flight.Property(p => p.Destination)
                .HasColumnName("Destination")
                .IsRequired();

            flight.Property(p => p.Price)
                .HasColumnName("Price")
                .IsRequired();

            flight.HasOne(p => p.Transport)
                .WithMany(t => t.Flights)
                .HasForeignKey(fk => fk.TransportId)
                .IsRequired();
        }

        private static void MapTransport(ModelBuilder mb)
        {
            var transport = mb.Entity<Transport>();

            transport.ToTable("TRANSPORTS");
            transport.HasKey(m => m.Id);

            transport.Property(p => p.FlightCarrier)
                .HasColumnName("FlightCarrier")
                .IsRequired();

            transport.Property(p => p.FlightNumber)
                .HasColumnName("FlightNumber")
                .IsRequired();

        }

    }
}
