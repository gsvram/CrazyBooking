using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarzyBooking.BL.UOW
{
    public interface IUnitOfWork
    {
        IBookingRepo BookingRepo { get; }
        IGalleryRepo GalleryRepo { get; }

        IGuestRepo GuestRepo { get; }

        IMovieRepo movieRepo { get; }

        IParkDetailsRepo ParkDetailsRepo { get; }

        ISeatingRepo SeatingRepo { get; }

        IShowRepo ShowRepo { get; }


        int Complete();
    }
}
