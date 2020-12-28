using BankSystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankSystem.IService
{
   public interface IBankAccountService
    {
        Task<List<BankAccount>> GetBankAccount();
        Task<int> AddBankAccount(BankAccount NewBankAccount);
        Task UpdateBankAccount(BankAccount updateBankAccount);
        BankAccount GetBankAccountbyId(int Id);
    }
}
