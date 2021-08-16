using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyBooking.Model
{
    public class Show :BaseEntity
    {
        public Show()
        {

        }
        public string TimeStart { get; set; }
        public string TimeEnd { get; set; }

        [ForeignKey("MovieId")]
        public Movie Movie { get; set; }
        [ForeignKey("ScreenId")]
        public Gallery Screen { get; set; }
      

    }
}
