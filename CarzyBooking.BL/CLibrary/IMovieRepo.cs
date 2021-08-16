using CrazyBooking.BL;
using CrazyBooking.Model;
using System.Collections.Generic;

namespace CarzyBooking.BL
{
    public interface IMovieRepo : IGenericRepository<Movie>
    {
        IEnumerable<Movie> GetMoiveDetails();
    }
}
