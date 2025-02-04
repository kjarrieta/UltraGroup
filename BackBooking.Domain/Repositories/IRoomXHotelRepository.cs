using BackBooking.Domain.BusisnesDTOs;
using BackBooking.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackBooking.Domain.Repositories
{
    public interface IRoomXHotelRepository
    {
        Task<RoomXHotel> GetByIdRoomXHotelAsync(int idroomxhotel);
        Task<List<RoomXHotel>> GetByIdHotel(int idhotel);
        Task<List<RoomXHotel>> GetByRoomXHotelStatus(Boolean roomxhotelstatus);
        Task CreatedRoomXHotelAsync(RoomXHotel roomxhotel);
        Task UpdateRoomXHotelAsync(RoomXHotel roomxhotel);
        Task<List<RoomXHotel>> GetByRoomXHotelAvailable(RoomXHotelAvailable roomXHotelAvailable);
        
    }
}
