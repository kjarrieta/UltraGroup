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
    public class UserAgencyRepository : IUserAgencyRepository
    {
        private readonly BackBookingContext _context;

        public UserAgencyRepository(BackBookingContext context)
        {
            _context = context;
        }
        public async Task CreatedUserAgencyAsync(UserAgency useragency)
        {
            await _context.TUserAgency.AddAsync(useragency);
            await _context.SaveChangesAsync();
        }

        public async Task<List<UserAgency>> GetAllUsersXAgencyAsync(int idagency)
        {
            {
                return await _context.TUserAgency
                                     .Where(x => x.IdAgency == idagency)
                                     .ToListAsync();
            }
        }
        public async Task<UserAgency> GetByIdDocumentUserAgencyAsync(int iddocumentuseragency)
        {
            var useragency = await _context.TUserAgency.AsNoTracking()
                                                     .FirstOrDefaultAsync(x => x.IdDocumentUserAgency == iddocumentuseragency);
            return useragency ?? new UserAgency();
        }

        public async Task UpdateUserAgencyAsync(UserAgency useragency)
        {
            _context.TUserAgency.Update(useragency);
            await _context.SaveChangesAsync();
        }
    }
}
