using CrazyBooking.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyBooking.DL
{
    public class CarzyBookingContext : DbContext
    {
        private readonly DbContextOptions<CarzyBookingContext> _options;

        public CarzyBookingContext(DbContextOptions<CarzyBookingContext> options) : base(options)
        {
            _options = options;
        }

        public DbSet<ParkDetails> ParkDetails { get; set; }

        public DbSet<Gallery> Galleries { get; set; }

        public DbSet<Seating> Seating { get; set; }
        public DbSet<Movie> Movies { get; set; }

        public DbSet<Show> Shows { get; set; }

        public DbSet<GuestDetails> GuestDetails { get; set; }

        public DbSet<BookingDetails> Booking {get;set;}


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            base.OnModelCreating(modelBuilder);
        }

      


    }
}
