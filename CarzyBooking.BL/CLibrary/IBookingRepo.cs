using CrazyBooking.BL;
using CrazyBooking.Model;
using System.Collections.Generic;

namespace CarzyBooking.BL
{
    public interface IBookingRepo : IGenericRepository<BookingDetails>
    {
        IEnumerable<BookingDetails> GetBookingDetails();

       int GetSeatsBookedByShowId(int showId);

        void CreateBooking(BookingDetails bookingDetails);
    }
}
