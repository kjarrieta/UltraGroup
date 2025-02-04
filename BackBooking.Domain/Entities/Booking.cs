using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackBooking.Domain.Entities
{
    public class Booking
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdBooking { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string? EmergencyPhone { get; set; }
        public string? EmergencyName { get; set; }
        public int NumberPeople { get; set; }
        public int IdRoomXHotel { get; set; }
        public int IdPayment { get; set; }
        public decimal TotalBooking { get; set; }
        public int GuestIdDocument {  get; set; }                   
        public Boolean BookingStatus { get; set; }
    }

}
