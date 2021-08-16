using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyBooking.Model
{
    public class Movie : BaseEntity
    {

        public string Name { get; set; }

        public AgeRatingType AllowedAge { get; set; }

        public int RunningDuration { get; set; }

        public ICollection<Show> ShowDetails { get; set; }

    }
}
