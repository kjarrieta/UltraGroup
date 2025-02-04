
using BackBooking.Application.BusinessRules;
using BackBooking.Domain.BusisnesDTOs;
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
    public class BookingRepository : IBookingRepository
    {
        private readonly BackBookingContext _context;
        private readonly GuestBusiness _GuestBusiness;

        public BookingRepository(BackBookingContext context, GuestBusiness GuestBusiness)
        {
            _context = context;
            _GuestBusiness = GuestBusiness;
        }

        public async Task CreatedBookingAsync(Booking booking)
        {
            await _context.TBooking.AddAsync(booking);
            await _context.SaveChangesAsync();
        }

        public async Task CreateDetailBookingXGuest(BookingGuest bookingGuest)
        {

            // Agregar la nueva reserva
            var booking = bookingGuest.Booking;
            await _context.TBooking.AddAsync(booking);
            await _context.SaveChangesAsync();

            // Crear registros de relación entre la reserva y los huéspedes
            foreach (var guestsbooking in bookingGuest.GuestsBooking)
            {
                await _context.TGuest.AddAsync(guestsbooking);
                await _context.SaveChangesAsync();

                var detailbookingxguest = new DetailBookingXGuest
                {
                    IdBooking = booking.IdBooking,
                    GuestIdDocument = guestsbooking.GuestIdDocument,
                    DetailBookingXGuestStatus = true

                };
                _context.TDetailBookingXGuest.Add(detailbookingxguest);
            }

            await _context.SaveChangesAsync();
        }

        public async Task<List<Guest>> GetGuestBooking(int IdBooking)
        {
            return await (from TDetailBookingXGuest in _context.TDetailBookingXGuest
                         join TGuest in _context.TGuest
                         on TDetailBookingXGuest.GuestIdDocument equals TGuest.GuestIdDocument
                         where TDetailBookingXGuest.IdBooking == IdBooking
                         select TGuest).ToListAsync();
            
        }

        public async Task<List<Booking>> GetAllBookingsAsync()
        {
            return await _context.TBooking.ToListAsync();
        }

        public async Task<Booking> GetByIdBookingAsync(int idbooking)
        {
            var booking = await _context.TBooking.AsNoTracking()
                                                   .FirstOrDefaultAsync(x => x.IdBooking == idbooking);
            return booking ?? new Booking();
        }

        public async Task<List<Booking>> GetByBookingStatusAsync(Boolean bookingstatus)
        {
            return await _context.TBooking
                                .Where(x => x.BookingStatus == bookingstatus)
                                .ToListAsync();
        }

        public async Task UpdateBookingAsync(Booking booking)
        {
            _context.TBooking.Update(booking);
            await _context.SaveChangesAsync();
        }      
      
    }
}
