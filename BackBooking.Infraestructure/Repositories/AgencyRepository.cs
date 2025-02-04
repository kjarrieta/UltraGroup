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
    public class AgencyRepository : IAgencyRepository
    {
        private readonly BackBookingContext _context;
        public AgencyRepository(BackBookingContext context)
        {
            _context = context;
        }
        public async Task CreatedAgencyAsync(Agency agency)
        {
            await _context.TAgency.AddAsync(agency);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Agency>> GetAllAgenciesAsync()
        {
            return await _context.TAgency.ToListAsync();
        }

        public async Task<Agency> GetByIdAgencyAsync(int IdAgency)
        {
            var agency = await _context.TAgency.AsNoTracking()
                                               .FirstOrDefaultAsync(x => x.IdAgency == IdAgency);
            return agency ?? new Agency();
        }

        public async Task UpdateAgencyAsync(Agency agency)
        {
            _context.TAgency.Update(agency);
            await _context.SaveChangesAsync();
        }
    }
}
