using CrazyBooking.BL;
using CrazyBooking.Model;
using System.Collections.Generic;

namespace CarzyBooking.BL
{
    public interface IShowRepo : IGenericRepository<Show>
    {
        IEnumerable<Show> GetShowDetails();

        Show GetFullDetailsById(int Id);
    }
}
