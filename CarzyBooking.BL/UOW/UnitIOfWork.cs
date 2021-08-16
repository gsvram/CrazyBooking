using CrazyBooking.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarzyBooking.BL.UOW
{
    public class UnitIOfWork : IUnitOfWork
    {

            private readonly CarzyBookingContext _context;
        public UnitIOfWork(CarzyBookingContext context)
        {
            _context = context;
            BookingRepo = new BookingRepo(_context);
            GalleryRepo = new GalleryRepo(_context);
            GuestRepo = new GuestRepo(_context);
            movieRepo = new MovieRepo(_context);
            ParkDetailsRepo = new ParkDetailsRepo(context);
            SeatingRepo = new SeatingRepo(context);
            ShowRepo = new ShowRepo(context);
        }
           

        public IBookingRepo BookingRepo { get; private set; }

        public IGalleryRepo GalleryRepo { get; private set; }

        public IGuestRepo GuestRepo { get; private set; }

        public IMovieRepo movieRepo { get; private set; }

        public IParkDetailsRepo ParkDetailsRepo { get; private set; }

        public ISeatingRepo SeatingRepo { get; private set; }

        public IShowRepo ShowRepo { get; private set; }

        public int Complete()
            {
                return _context.SaveChanges();
            }
            public void Dispose()
            {
                _context.Dispose();
            }
        
    }
}
