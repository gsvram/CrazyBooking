using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyBooking.Model
{
    public class GuestDetails :BaseEntity
    {
        public string UserName {get;set;}

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MiddleName { get; set; }

        public bool IsAdult { get; set; }

        public bool IsMainTicketHolder { get; set; }
    }
}
