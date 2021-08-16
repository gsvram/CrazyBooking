using AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace CrazyBooking.Model
{
    public class vmBookingDetails
    {
        public int ShowId { get; set; }
        [Required]
        public int NumberOfTickets { get; set; } = 1;

        public List<GuestDetails> GuestDetails { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LName { get; set; }

        public string MName { get; set; }

        public bool IsAdult { get; set; }

        public string TheaterName { get; set; }

        public string MovieName { get; set; }

        public string ScreenName { get; set; }

        public string ShowTime { get; set; }

        public decimal Price { get; set; }

        public decimal TotalCost { get { return Price * NumberOfTickets; } }

        public int TotalSeats { get; set; } 

        public int SoldSeats { get; set; }

        public int AvaiableSeats { get { return TotalSeats - SoldSeats; }  }

        public string[] SeatList { get; set; }

      

    }



}
