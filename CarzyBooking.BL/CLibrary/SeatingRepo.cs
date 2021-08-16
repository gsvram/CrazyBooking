using CrazyBooking.BL;
using CrazyBooking.DL;
using CrazyBooking.Model;
using System.Collections.Generic;
using System.Linq;

namespace CarzyBooking.BL
{
    public class SeatingRepo : GenericRepository<Seating>, ISeatingRepo
    {
        public SeatingRepo(CarzyBookingContext context) : base(context)
        {
        }

       
        public IEnumerable<Seating> GetSeatingDetails() => _context.Seating.OrderByDescending(d => d).ToList();
    }
}
