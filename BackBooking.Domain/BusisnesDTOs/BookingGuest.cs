using BackBooking.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackBooking.Domain.BusisnesDTOs
{
    public class BookingGuest
    {        
        public Guest Guest { get; set; }
        public Booking Booking { get; set; }
        public List<Guest> GuestsBooking { get; set; }
    }
}
