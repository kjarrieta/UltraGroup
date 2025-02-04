using BackBooking.Domain.BusisnesDTOs;
using BackBooking.Domain.Entities;
using BackBooking.Domain.Repositories;
using BackBooking.Infraestructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackBooking.Infraestructure.Repositories
{
    public class RoomXHotelRepository : IRoomXHotelRepository
    {
        private readonly BackBookingContext _context;

        public RoomXHotelRepository(BackBookingContext context)
        {
            _context = context;
        }
        public async Task CreatedRoomXHotelAsync(RoomXHotel roomxhotel)
        {
            await _context.TRoomXHotel.AddAsync(roomxhotel);
            await _context.SaveChangesAsync();
        }
        public async Task<RoomXHotel> GetByIdRoomXHotelAsync(int idroomxhotel)
        {
            var roomxhotel = await _context.TRoomXHotel.AsNoTracking().FirstOrDefaultAsync(x => x.IdRoomXHotel == idroomxhotel);
            return roomxhotel ?? new RoomXHotel();
        }
        public async Task<List<RoomXHotel>> GetByIdHotel(int idhotel)
        {
            return await _context.TRoomXHotel
                                 .Where(x => x.IdHotel == idhotel)
                                 .ToListAsync();
        }

        public async Task<List<RoomXHotel>> GetByRoomXHotelStatus(Boolean roomxhotelstatus)
        {
            return await _context.TRoomXHotel
                                 .Where(x => x.RoomXHotelStatus == roomxhotelstatus)
                                 .ToListAsync();
        }
        public async Task UpdateRoomXHotelAsync(RoomXHotel roomxhotel)
        {
            _context.TRoomXHotel.Update(roomxhotel);
            await _context.SaveChangesAsync();
        }

        public  async Task<List<RoomXHotel>> GetByRoomXHotelAvailable(RoomXHotelAvailable roomXHotelAvailable)
        {
            return await (from TRoomXHotel in _context.TRoomXHotel
                          join hotel in _context.THotel on TRoomXHotel.IdHotel equals hotel.IdHotel
                          join booking in _context.TBooking on TRoomXHotel.IdRoomXHotel equals booking.IdRoomXHotel into bookingGroup
                          from booking in bookingGroup.DefaultIfEmpty()
                          where hotel.HotelStatus == true
                                && TRoomXHotel.RoomXHotelStatus == true
                                && TRoomXHotel.NumberPeople == roomXHotelAvailable.NumberPeople
                                && hotel.HotelCountry == roomXHotelAvailable.HotelCountry
                                && (booking == null || booking.EndDate < roomXHotelAvailable.StartDate || booking.StartDate > roomXHotelAvailable.EndDate)
                          select TRoomXHotel).Distinct().ToListAsync();
        }
    }
}
