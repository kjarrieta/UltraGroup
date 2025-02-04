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
    public class UserGuestRepository : IUserGuestRepository
    {
        private readonly BackBookingContext _context;
        public UserGuestRepository(BackBookingContext context)
        {
            _context = context;
        }

        public async Task CreatedUserGuestAsync(UserGuest userguest)
        {
            await _context.TUserGuest.AddAsync(userguest);
            await _context.SaveChangesAsync();
        }

        public async Task<UserGuest> GetByIdUserGuestAsync(int iduserguest)
        {
            var userguest = await _context.TUserGuest.AsNoTracking()
                                                     .FirstOrDefaultAsync(x => x.IdUserGuest == iduserguest);
            return userguest ?? new UserGuest();
        }

        public async Task UpdateUserGuestAsync(UserGuest userguest)
        {
            _context.TUserGuest.Update(userguest);
            await _context.SaveChangesAsync();
        }
    }
}
