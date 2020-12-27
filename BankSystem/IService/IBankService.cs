using BankSystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankSystem.IService
{
    public interface IBankService
    {
        Task<List<Bank>> GetBanks();
        Task<bool> AddBank(Bank newBank);
        Task<bool> UpdateBank(Bank updateBank);
        Task<bool> DeleteBank(Bank deleteBank);
        Bank GeBankById(int Id);
    }
}
