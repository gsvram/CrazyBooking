using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyBooking.Model
{
    public class Seating : BaseEntity
    {
        public string SeatNumber { get; set; }

        public int RowNumber { get; set; }

        public decimal Cost { get; set; }

        public Gallery Screen { get; set; }
    }
}
