using CrazyBooking.BL;
using CrazyBooking.Model;
using System.Collections.Generic;

namespace CarzyBooking.BL
{
    public interface ISeatingRepo : IGenericRepository<Seating>
    {
        IEnumerable<Seating> GetSeatingDetails();
    }
}
