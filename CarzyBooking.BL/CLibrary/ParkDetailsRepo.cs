using CrazyBooking.BL;
using CrazyBooking.DL;
using CrazyBooking.Model;
using System.Collections.Generic;
using System.Linq;

namespace CarzyBooking.BL
{
    public class ParkDetailsRepo : GenericRepository<ParkDetails>, IParkDetailsRepo
    {
        public ParkDetailsRepo(CarzyBookingContext context) : base(context)
        {
        }
        public IEnumerable<ParkDetails> PParkDetails => _context.ParkDetails.OrderByDescending(d => d).ToList();
    }
}
