using BackBooking.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackBooking.Domain.Repositories
{
    public interface IAgencyRepository
    {
        Task<List<Agency>> GetAllAgenciesAsync();
        Task<Agency> GetByIdAgencyAsync(int idagency);
        Task CreatedAgencyAsync(Agency agency );
        Task UpdateAgencyAsync(Agency agency);
    }
}
