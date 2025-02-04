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
    public class GuestRepository : IGuestRepository
    {
        private readonly BackBookingContext _context;

        public GuestRepository(BackBookingContext context)
        {
            _context = context;
        }

        public async Task CreatedGuestAsync(Guest guest)
        {
            await _context.TGuest.AddAsync(guest);
            await _context.SaveChangesAsync();
        }

        public async Task<Guest> GetByGuestIdDocumentAsync(int guestiddocument)
        {
            var guest = await _context.TGuest.AsNoTracking()
                                                   .FirstOrDefaultAsync(x => x.GuestIdDocument == guestiddocument);
            return guest ?? new Guest();
        }

        public async Task UpdateGuestAsync(Guest guest)
        {
            _context.TGuest.Update(guest);
            await _context.SaveChangesAsync();
        }
    }
}
