using CrazyBooking.BL;
using CrazyBooking.DL;
using CrazyBooking.Model;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace CarzyBooking.BL
{
    public class ShowRepo : GenericRepository<Show>, IShowRepo
    {
        public ShowRepo(CarzyBookingContext context) : base(context)
        {
        }

        /// <summary>
        /// Try to avoid the Lazy Loading and 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Show> GetShowDetails() => _context.Shows
                                                                .AsNoTracking()
                                                                .Include(i=>i.Movie)
                                                                .Include(i => i.Screen)
                                                                .Include(i=>i.Screen.Prak)
                                                                .Include(i => i.Screen.Seatings)
                                                                .OrderByDescending(d => d).ToList();

        public Show GetFullDetailsById(int Id) => _context.Shows
                                                                .AsNoTracking()
                                                                .Include(i => i.Movie)
                                                                .Include(i => i.Screen)
                                                                .Include(i => i.Screen.Prak)
                                                                .Include(i => i.Screen.Seatings)
                                                                .FirstOrDefault(x => x.Id == Id);
                                                                
    }
}
