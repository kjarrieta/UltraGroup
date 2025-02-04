using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackBooking.Domain.Entities
{
    public class DetailBookingXGuest
    {        
        public int IdBooking { get; set; }
      //  public Booking Booking { get; set; }
        public int GuestIdDocument { get; set; }
      //  public Guest Guest { get; set; }
        public Boolean DetailBookingXGuestStatus { get; set; }
    }
}
