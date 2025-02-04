using BackBooking.Domain.BusisnesDTOs;
using BackBooking.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackBooking.Domain.Repositories
{
    public interface IBookingRepository
    {
        Task<List<Booking>> GetAllBookingsAsync();
        Task<Booking> GetByIdBookingAsync(int idbooking);
        Task<List<Booking>> GetByBookingStatusAsync(Boolean bookingstatus);        
        Task CreatedBookingAsync(Booking booking);
        Task UpdateBookingAsync(Booking booking);
        Task CreateDetailBookingXGuest(BookingGuest bookingGuest);
        Task<List<Guest>> GetGuestBooking(int IdBooking);
    }
}
