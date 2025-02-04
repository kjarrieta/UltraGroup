using BackBooking.Domain.Entities;
using BackBooking.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackBooking.Application.BusinessRules
{
    public class HotelBusiness
    {

        private readonly IHotelRepository _ihotelrepository;

        public HotelBusiness(IHotelRepository ihotelRepository)
        {

            _ihotelrepository = ihotelRepository;
        }
        public async Task<List<Hotel>> GetHotelsAsync()
        {
            try
            {
                return await _ihotelrepository.GetAllHotelsAsync();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<List<Hotel>> GetByHotelStatus(Boolean hotelstatus)
        {
            try
            {
                return await _ihotelrepository.GetByHotelStatus(hotelstatus);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<Hotel>> GetByHotelFavorite(Boolean hotelhavorite)
        {
            try
            {
                return await _ihotelrepository.GetByHotelFavorite(hotelhavorite);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task<Hotel> GetHotelById(int idhotel)
        {
            try
            {
                return await _ihotelrepository.GetByIdHotelAsync(idhotel);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task CreateHotelAsync(Hotel hotel)
        {

            try
            {
               
                await _ihotelrepository.CreateHoteldAsync(hotel);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task UpdateHotelAsync(Hotel hotel)
        {

            try
            {
                await _ihotelrepository.UpdateHotelAsync(hotel);
            }
            catch (Exception)
            {

                throw;
            }

        }

    }
}
