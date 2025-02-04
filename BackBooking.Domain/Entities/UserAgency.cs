using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackBooking.Domain.Entities
{
    public class UserAgency
    {
        [Key]        
        public int IdDocumentUserAgency { get; set; }
        public int IdAgency { get; set; }
        public int IdTypeUser { get; set; }
        public string UserAgencyMail { get; set; }
        public string UserAgencyPassword { get; set; }
        public string UserAgencyName { get; set; }
        public string UserAgencyPhone { get; set; }
        public Boolean UserAgencyStatus { get; set; }
    }
}
