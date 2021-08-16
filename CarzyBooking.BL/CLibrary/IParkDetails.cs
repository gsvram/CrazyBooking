using CrazyBooking.BL;
using CrazyBooking.Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CarzyBooking.BL
{
    public interface IParkDetailsRepo : IGenericRepository<ParkDetails>
    {

        IEnumerable<ParkDetails> PParkDetails { get; }
    }
}
