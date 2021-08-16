using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyBooking.Model
{
    public class BookingDetails:BaseEntity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string SeatNumber { get; set; }

       
        public int ShowID { get; set; }

        [ForeignKey("ShowID")]
        public Show Show { get; set; }
      
        public int TotalTickets { get; set; }


    }
}
