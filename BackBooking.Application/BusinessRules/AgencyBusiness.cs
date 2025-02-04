using BackBooking.Domain.Entities;
using BackBooking.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackBooking.Application.BusinessRules
{
    public class AgencyBusiness
    {
        private readonly IAgencyRepository _iagencyrepository;

        public AgencyBusiness(IAgencyRepository iagencyrepository)
        {
            _iagencyrepository = iagencyrepository;
        }

        public async Task<List<Agency>> GetAllAgenciesAsync()
        {
            try
            {
                return await _iagencyrepository.GetAllAgenciesAsync();
            }
            catch (Exception ex)
            {
                throw;
            }

        }
        public async Task<Agency> GetByIdAgencyAsync(int idagency)
        {
            try
            {
                return await _iagencyrepository.GetByIdAgencyAsync(idagency);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task CreatedAgencyAsync(Agency agency)
        {
            try
            {

                await _iagencyrepository.CreatedAgencyAsync(agency);
            }
            catch (Exception)
            {

                throw;
            }

        }
        public async Task UpdateAgencyAsync(Agency agency)
        {

            try
            {
                await _iagencyrepository.UpdateAgencyAsync(agency);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
