using CrazyBooking.BL;
using CrazyBooking.Model;
using System.Collections.Generic;

namespace CarzyBooking.BL
{
    public interface IGuestRepo : IGenericRepository<GuestDetails>
    {
        IEnumerable<GuestDetails> GetGuestInfo();
    }
}
