using BackBooking.Domain.Entities;
using BackBooking.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackBooking.Application.BusinessRules
{
    public class GuestBusiness
    {
        private readonly IGuestRepository _iguestrepository;

        public GuestBusiness(IGuestRepository iguestrepository)
        {
            _iguestrepository = iguestrepository;
        }

        public async Task<Guest> GetByGuestIdDocumentAsync(int guestiddocument)
        {
            try
            {
                return await _iguestrepository.GetByGuestIdDocumentAsync(guestiddocument);
            }
            catch (Exception)
            {

                throw;
            }
        }
            public async Task CreatedGuestAsync(Guest guest)
        {
            try
            {

                await _iguestrepository.CreatedGuestAsync(guest);
            }
            catch (Exception)
            {

                throw;
            }

        }
        public async Task UpdateGuestAsync(Guest guest)
        {
            try
            {
                await _iguestrepository.UpdateGuestAsync(guest);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
