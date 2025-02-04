using BackBooking.Domain.Entities;
using BackBooking.Domain.Repositories;
using BackBooking.Infraestructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackBooking.Infraestructure.Repositories
{
    public class HotelRepository : IHotelRepository
    {
        private readonly BackBookingContext _context;
        public HotelRepository(BackBookingContext context)
        {
            _context = context;
        }

        public async Task CreateHoteldAsync(Hotel hotel)
        {
            await _context.THotel.AddAsync(hotel);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Hotel>> GetAllHotelsAsync()
        {
          return await _context.THotel.ToListAsync();
        }

        public async Task<List<Hotel>> GetByHotelStatus(Boolean hotelstatus)
        {
            return await _context.THotel
                                 .Where(x => x.HotelStatus == hotelstatus)
                                 .ToListAsync();

        }
        

        public async Task<List<Hotel>> GetByHotelFavorite(Boolean hotelhavorite)
        {
            return await _context.THotel
                                 .Where(x => x.HotelFavorite == hotelhavorite)
                                 .ToListAsync();

        }
        public async Task<Hotel> GetByIdHotelAsync(int idhotel)
        {
            var hotel = await _context.THotel.AsNoTracking().FirstOrDefaultAsync(x => x.IdHotel ==  idhotel);
            return hotel ?? new Hotel();
        }

        public async Task UpdateHotelAsync(Hotel hotel)
        {
            _context.THotel.Update(hotel);
            await _context.SaveChangesAsync();
        }
    }
}
