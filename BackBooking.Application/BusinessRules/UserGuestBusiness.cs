using BackBooking.Domain.Entities;
using BackBooking.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackBooking.Application.BusinessRules
{
    public class UserGuestBusiness
    {
        private readonly IUserGuestRepository _iuserGuestRepository;

        public UserGuestBusiness(IUserGuestRepository iuserGuestRepository)
        {
            _iuserGuestRepository = iuserGuestRepository;
        }

        public async Task<UserGuest> GetByIdUserGuestAsync(int iduserguest)
        {
            try
            {
                return await _iuserGuestRepository.GetByIdUserGuestAsync(iduserguest);
            }
            catch (Exception)
            {

                throw;
            }

        }
        public async Task CreatedUserGuestAsync(UserGuest userguest)
        {
            try
            {
                 await _iuserGuestRepository.CreatedUserGuestAsync(userguest);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task UpdateUserGuestAsync(UserGuest userguest)
        {
            try
            {
                 await _iuserGuestRepository.UpdateUserGuestAsync(userguest);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
