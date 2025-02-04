using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackBooking.Domain.BusisnesDTOs
{
    public class RoomXHotelAvailable
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int NumberPeople { get; set; }
        public string HotelCountry { get; set; }
    }
}
