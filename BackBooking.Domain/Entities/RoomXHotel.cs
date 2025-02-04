using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackBooking.Domain.Entities
{
    public class RoomXHotel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdRoomXHotel { get; set; }
        public int IdHotel { get; set; }
        public int IdTypeRoom { get; set; }
        public int NumberPeople { get; set; }
        public decimal BaseCosto { get; set; }
        public decimal Taxes { get; set; }
        public string Location { get; set; }
        public Boolean RoomXHotelStatus { get; set; }

    }
}
