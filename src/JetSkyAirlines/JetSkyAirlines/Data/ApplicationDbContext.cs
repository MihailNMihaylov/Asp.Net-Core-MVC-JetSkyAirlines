using System;
using System.Collections.Generic;
using System.Text;
using JetSkyAirlines.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace JetSkyAirlines.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Airplane> Airplanes { get; set; }

        public DbSet<Airport> Airports { get; set; }

        public DbSet<Luggage> Luggages { get; set; }

        public DbSet<Feedback> Feedbacks { get; set; }

        public DbSet<Flight> Flights { get; set; }
        
        public ApplicationDbContext()
        {

        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Airplane>(x =>
            {
                x.HasKey(z => new
                {
                    z.Id
                });
            });

            builder.Entity<Airport>(x =>
            {
                x.HasKey(z => z.Id);
            });

            builder.Entity<Luggage>(x =>
            {
                x.HasKey(z => z.Id);
            });
        }
    }
}
