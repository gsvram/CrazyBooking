using CrazyBooking.BL;
using CrazyBooking.DL;
using CrazyBooking.Model;
using System.Collections.Generic;
using System.Linq;

namespace CarzyBooking.BL
{
    public class GuestRepo : GenericRepository<GuestDetails>, IGuestRepo
    {
        public GuestRepo(CarzyBookingContext context) : base(context)
        {
        }


        public IEnumerable<GuestDetails> GetGuestInfo() => _context.GuestDetails.OrderByDescending(d => d).ToList();
    }
}
