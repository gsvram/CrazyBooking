using CrazyBooking.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyBooking.DL
{
    public static  class SeedBuilder
    {

        public static  void BuildEntity(IServiceProvider serviceProvider)
        {

            var context = new CarzyBookingContext(serviceProvider.GetRequiredService<DbContextOptions<CarzyBookingContext>>());
            context.Database.EnsureCreated();

            if (!context.Shows.Any())
            {
                var pd1 = new ParkDetails() { Address = "The O2, Peninsula Square, London SE10 0DX", Name = "The O2" };
                var pd2 = new ParkDetails() { Address = "1 Charlie Chaplin Walk, Waterloo SE1 8XR", Name = "British Film Institute IMAX " };

                context.Add(pd1);
                context.Add(pd2);
                context.SaveChanges();

                var g11 = new Gallery { Name = "Screen 1", TotalTickets = 60, GallaryType = CrazyBooking.Model.Enum.GalleryType.BigScreen, Prak = pd1 };
                var g12 = new Gallery { Name = "OpenAir 1", TotalTickets = 80, GallaryType = CrazyBooking.Model.Enum.GalleryType.OpenAir, Prak = pd1 };
                var g21 = new Gallery { Name = "Screen 1", TotalTickets = 70, GallaryType = CrazyBooking.Model.Enum.GalleryType.BigScreen, Prak = pd2 };
                var g22 = new Gallery { Name = "DriveIn 1", TotalTickets = 30, GallaryType = CrazyBooking.Model.Enum.GalleryType.DriveIn, Prak = pd2 };

                context.Add(g11);
                context.Add(g12);
                context.Add(g21);
                context.Add(g22);
                context.SaveChanges();

                GenerateSeats(context, g11);
                GenerateSeats(context, g12);
                GenerateSeats(context, g21);
                GenerateSeats(context, g22);

                var mv1 = new Movie() { AllowedAge = AgeRatingType.Universal, Name = "The Dog's Journey", RunningDuration = 60 };
                var mv2 = new Movie() { AllowedAge = AgeRatingType.Universal, Name = "Wonder", RunningDuration = 180, };


                context.Add(mv1);
                context.Add(mv2);
                context.SaveChanges();


                var s11 = new Show() { Movie = mv1, Screen = g11, TimeStart = "12:00 PM", TimeEnd = "01:00 PM" };
                var s12 = new Show() { Movie = mv1, Screen = g12, TimeStart = "03:00 PM", TimeEnd = "04:00 PM" };

                var s21 = new Show() { Movie = mv2, Screen = g21, TimeStart = "12:00 PM", TimeEnd = "01:00 PM" };
                var s22 = new Show() { Movie = mv2, Screen = g22, TimeStart = "03:00 PM", TimeEnd = "04:00 PM" };

                context.Add(s11);
                context.Add(s12);
                context.Add(s21);
                context.Add(s22);
                context.SaveChanges();
            }
        }


        private static void GenerateSeats(CarzyBookingContext context, Gallery gl)
        {
            var j = 0;
            List<Seating> listST = new List<Seating>();
            for (var i = 1; i < gl.TotalTickets; i++)
            {
                if (i > 25) j = 0; ;
                listST.Add(new Seating { Screen = gl, Cost = 7.00m, SeatNumber = $"{gl.GallaryType}{i.ToString().PadLeft(2, '0')}", RowNumber = ++j });
            }
            context.AddRange(listST);
            context.SaveChanges();
        }
    }
}
