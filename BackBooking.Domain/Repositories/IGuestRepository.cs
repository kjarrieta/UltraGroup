using BackBooking.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackBooking.Domain.Repositories
{
    public interface IGuestRepository
    {
        Task<Guest> GetByGuestIdDocumentAsync(int guestiddocument);       
        Task CreatedGuestAsync(Guest guest);
        Task UpdateGuestAsync(Guest guest);
    }
}
