using CrazyBooking.BL;
using CrazyBooking.Model;
using System.Collections.Generic;

namespace CarzyBooking.BL
{
    public interface IGalleryRepo : IGenericRepository<Gallery>
    {
        IEnumerable<Gallery> GalleryDetails { get; }
    }
}
