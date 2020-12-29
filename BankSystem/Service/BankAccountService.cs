using BankSystem.Data;
using BankSystem.IService;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankSystem.Service
{
    public class BankAccountService: IBankAccountService
    {
        private readonly ApplicationDbContext _db;
        public BankAccountService(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<List<BankAccount>> GetBankAccount()
        {
            if (_db != null)
            {
                return await _db.bankaccount.Where(BA => BA.IsDeleted == false).Include(x => x.bank).Include(c=>c.currency).ToListAsync();
            }
            return null;
        }
        public async Task<int> AddBankAccount(BankAccount NewBankAccount)
        {
            if (_db != null)
            {
                NewBankAccount.CreateDate = DateTime.Now;
                await _db.bankaccount.AddAsync(NewBankAccount);
                await _db.SaveChangesAsync();
                return NewBankAccount.Id;
            }
            return 0;
        }
        public async Task UpdateBankAccount(BankAccount updateBankAccount)
        {
            if (_db != null)
            {        
                _db.bankaccount.Update(updateBankAccount);
                await _db.SaveChangesAsync();
            }
        }
        public BankAccount GetBankAccountbyId(int Id)
        {
            if (_db != null)
            {
                return _db.bankaccount.Find(Id); ;
            }

            return null;
        }      
    }
}
