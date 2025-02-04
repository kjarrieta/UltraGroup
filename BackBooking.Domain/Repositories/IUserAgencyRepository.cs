using BackBooking.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackBooking.Domain.Repositories
{
    public interface IUserAgencyRepository
    {
        Task<List<UserAgency>> GetAllUsersXAgencyAsync(int idagency);
        Task<UserAgency> GetByIdDocumentUserAgencyAsync(int iddocumentuseragency);
        Task CreatedUserAgencyAsync(UserAgency useragency);
        Task UpdateUserAgencyAsync(UserAgency useragency);
    }
}
