using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackBooking.Domain.Entities
{
    public class Agency
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdAgency { get; set; }
        public string AgencyName { get; set; }
        public string AgencyCity { get; set; }
        public Boolean AgencyStatus { get; set; } 

    }
}
