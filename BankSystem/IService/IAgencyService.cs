using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankSystem.Data;
namespace BankSystem.IService
{
   public interface IAgencyService
    {
        Task<List<Agency>> GetAgencies();
        Task<bool> AddAgency(Agency newAgency);
        Task<bool> UpdateAgency(Agency updateAgency);
        Task<bool> DeleteAgency(Agency deleteAgency);
        Agency GetAgencyById(int Id);
    }
}
