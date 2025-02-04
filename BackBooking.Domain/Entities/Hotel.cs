using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BackBooking.Domain.Entities
{
    public class Hotel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdHotel {  get; set; }

        public string HotelName { get; set; }
        public string HotelCountry { get; set; }
        public string HotelPhone { get; set; }
        public string Hoteladdress { get; set; }

        public Boolean HotelFavorite { get; set; }
        
        public Boolean HotelStatus { get; set; }
  
  

    }
}
