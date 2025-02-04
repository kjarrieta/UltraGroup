using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackBooking.Domain.Entities
{
    public class Guest
    {
        [Key]
        
        public int GuestIdDocument { get; set; }
        public string TypeDocument { get; set; }
        public string  GuestName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public string GuestMail { get; set; }
        public string GuestPhone { get; set; }
        public Boolean GuestStatus { get; set; }
       // public ICollection<DetailBookingXGuest> DetailBookingXGuest { get; set; }

    }
}
