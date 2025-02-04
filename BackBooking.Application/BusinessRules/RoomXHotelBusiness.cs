using BackBooking.Domain.BusisnesDTOs;
using BackBooking.Domain.Entities;
using BackBooking.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackBooking.Application.BusinessRules
{
    public class RoomXHotelBusiness
    {
        private readonly IRoomXHotelRepository _iroomxhotelrepository;

        public RoomXHotelBusiness(IRoomXHotelRepository iroomxhotelrepository)
        {
            _iroomxhotelrepository = iroomxhotelrepository;
        }

        public async Task<RoomXHotel> GetByIdRoomXHotelAsync(int idroomxhotel)
        {
            try
            {
                return await _iroomxhotelrepository.GetByIdRoomXHotelAsync(idroomxhotel);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<RoomXHotel>> GetByRoomXHotelStatus(Boolean roomxhotelstatus)
        {
            try
            {
                return await _iroomxhotelrepository.GetByRoomXHotelStatus(roomxhotelstatus);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<RoomXHotel>> GetByIdHotel(int idhotel)
        {
            try
            {
                return await _iroomxhotelrepository.GetByIdHotel(idhotel);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<List<RoomXHotel>> GetByRoomXHotelAvailable(RoomXHotelAvailable roomXHotelAvailable)
        {

            try
            {
                return await _iroomxhotelrepository.GetByRoomXHotelAvailable(roomXHotelAvailable);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task CreateRoomXHotelAsync(RoomXHotel roomxhotel)
        {

            try
            {

                await _iroomxhotelrepository.CreatedRoomXHotelAsync(roomxhotel);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task UpdateRoomXHotellAsync(RoomXHotel roomxhotel)
        {

            try
            {
                await _iroomxhotelrepository.UpdateRoomXHotelAsync(roomxhotel);
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
