using BackBooking.Domain.Entities;
using BackBooking.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackBooking.Application.BusinessRules
{
    public class UserAgencyBusiness
    {
        private readonly IUserAgencyRepository _iuserAgencyRepository;

        public UserAgencyBusiness(IUserAgencyRepository iuserAgencyRepository)
        {
            _iuserAgencyRepository = iuserAgencyRepository;
        }

        public async Task<List<UserAgency>> GetAllUsersXAgencyAsync(int idagency)
        {
            try
            {
                return await _iuserAgencyRepository.GetAllUsersXAgencyAsync(idagency);
            }
            catch (Exception)
            {

                throw;
            }


        }
        public async Task<UserAgency> GetByIdDocumentUserAgencyAsync(int iddocumentuseragency)
        {
            try
            {
                return await _iuserAgencyRepository.GetByIdDocumentUserAgencyAsync(iddocumentuseragency);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task CreatedUserAgencyAsync(UserAgency useragency)
        {
            try
            {

                await _iuserAgencyRepository.CreatedUserAgencyAsync(useragency);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task UpdateUserAgencyAsync(UserAgency useragency)
        {
            try
            {
                await _iuserAgencyRepository.UpdateUserAgencyAsync(useragency);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
