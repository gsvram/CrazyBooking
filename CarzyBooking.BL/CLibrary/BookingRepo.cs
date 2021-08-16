using CrazyBooking.BL;
using CrazyBooking.DL;
using CrazyBooking.Model;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace CarzyBooking.BL
{
    public class BookingRepo : GenericRepository<BookingDetails>, IBookingRepo
    {
        public BookingRepo(CarzyBookingContext context) : base(context)
        {
        }


        public IEnumerable<BookingDetails> GetBookingDetails() => _context.Booking.OrderByDescending(d => d).ToList();

        public int GetSeatsBookedByShowId(int showId) => _context.Booking.Where(x => x.Show.Id == showId).Sum(s => s.TotalTickets);

        public void CreateBooking(BookingDetails bookingDetails)
        {
            _context.Add(bookingDetails);
            _context.SaveChanges();
        }

    }
}
