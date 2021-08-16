using CrazyBooking.BL;
using CrazyBooking.DL;
using CrazyBooking.Model;
using System.Collections.Generic;
using System.Linq;

namespace CarzyBooking.BL
{
    public class MovieRepo : GenericRepository<Movie>, IMovieRepo
    {
        public MovieRepo(CarzyBookingContext context) : base(context)
        {
        }


        public IEnumerable<Movie> GetMoiveDetails() => _context.Movies.OrderByDescending(d => d).ToList();
    }
}
