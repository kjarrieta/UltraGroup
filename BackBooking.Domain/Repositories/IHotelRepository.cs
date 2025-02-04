using BackBooking.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackBooking.Domain.Repositories
{
    public interface IHotelRepository
    {

        Task<List<Hotel>> GetAllHotelsAsync();
        Task<List<Hotel>> GetByHotelStatus(Boolean hotelstatus);
        Task<List<Hotel>> GetByHotelFavorite(Boolean hotelhavorite);
        Task<Hotel> GetByIdHotelAsync(int idhotel);
        Task CreateHoteldAsync(Hotel hotel);
        Task UpdateHotelAsync(Hotel hotel);
        


    }
}
