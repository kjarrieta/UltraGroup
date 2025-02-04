using BackBooking.Application.Services;
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
    public class BookingBusiness
    {

        private readonly IBookingRepository _ibookingrepository;
        private readonly EmailService _emailService;

        public BookingBusiness(IBookingRepository ibookingrepository, EmailService emailService)
        {
            _ibookingrepository = ibookingrepository;
            _emailService = emailService;
        }

        public async Task CreatedBookingAsync(Booking booking)
        {

            try
            {

                await _ibookingrepository.CreatedBookingAsync(booking);
               
            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task<List<Booking>> GetAllBookingsAsync()
        {
            try
            {
                return await _ibookingrepository.GetAllBookingsAsync();
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public async Task<Booking> GetByIdBookingAsync(int idbooking)
        {
            try
            {
                return await _ibookingrepository.GetByIdBookingAsync(idbooking);
            }
            catch (Exception)
            {

                throw;
            }

        }

        public async Task<List<Booking>> GetByBookingStatusAsync(Boolean bookingstatus)
        {
            try
            {
                return await _ibookingrepository.GetByBookingStatusAsync(bookingstatus);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task<List<Guest>> GetGuestBooking(int IdBooking)
        {

            try
            {
                return await _ibookingrepository.GetGuestBooking(IdBooking);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task CreateDetailBookingXGuest(BookingGuest bookingGuest)
        {
            try
            {
                 await _ibookingrepository.CreateDetailBookingXGuest(bookingGuest);   
                 await _emailService.SendEmailAsync(bookingGuest);
               
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task UpdateBookingAsync(Booking booking)
        {

            try
            {
                await _ibookingrepository.UpdateBookingAsync(booking);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
