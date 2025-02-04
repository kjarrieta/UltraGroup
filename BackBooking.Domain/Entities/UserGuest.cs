using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackBooking.Domain.Entities
{
    public class UserGuest
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdUserGuest { get; set; }

        public int GuestIdDocument { get; set; }
        public string UserGuestPassword { get; set; }
    }
}
