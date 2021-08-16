using CrazyBooking.Model.Enum;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrazyBooking.Model
{
    public class Gallery : BaseEntity
    {
        public string Name { get; set; }
        public int TotalTickets { get; set; } 

        public GalleryType GallaryType { get; set; }

        [ForeignKey("ParkDetailsId")]
        public ParkDetails Prak { get; set; }

        public ICollection<Show> ShowDetails { get; set; }

        public ICollection<Seating> Seatings { get; set; }
    }
}
