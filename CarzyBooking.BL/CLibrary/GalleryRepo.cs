using CrazyBooking.BL;
using CrazyBooking.DL;
using CrazyBooking.Model;
using System.Collections.Generic;
using System.Linq;

namespace CarzyBooking.BL
{
    public class GalleryRepo : GenericRepository<Gallery>, IGalleryRepo
    {
        public GalleryRepo(CarzyBookingContext context) : base(context)
        {
        }

        public IEnumerable<Gallery> GalleryDetails => _context.Galleries.OrderByDescending(d => d).ToList();
    }
}
