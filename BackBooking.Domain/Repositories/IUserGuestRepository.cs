using BackBooking.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackBooking.Domain.Repositories
{
    public interface IUserGuestRepository
    {
        Task<UserGuest> GetByIdUserGuestAsync(int iduserguest);       
        Task CreatedUserGuestAsync(UserGuest userguest);
        Task UpdateUserGuestAsync(UserGuest userguest);

    }
}
