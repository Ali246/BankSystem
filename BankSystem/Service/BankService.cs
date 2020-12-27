using Microsoft.EntityFrameworkCore;
using BankSystem.IService;
using BankSystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace BankSystem.Service
{
    public class BankService : IBankService
    {
        private readonly ApplicationDbContext _db;
        public BankService(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<List<Bank>> GetBanks()
        {
            return await _db.bank.Where(x => x.IsDeleted == false).ToListAsync();
        }
        public async Task<bool> AddBank(Bank newBank)
        {
            newBank.IsDeleted = false;
            newBank.CreateDate = DateTime.Now;
            await _db.bank.AddAsync(newBank);
            _db.SaveChanges();
            return true;
        }
        public async Task<bool> UpdateBank(Bank updateBank)
        {
            updateBank.modifiedDate = DateTime.Now;
            _db.bank.Update(updateBank);
            await _db.SaveChangesAsync();
            return true;
        }
        public async Task<bool> DeleteBank(Bank deleteBank)
        {
            _db.bank.Update(deleteBank);
            await _db.SaveChangesAsync();
            return true;
        }
        public Bank GeBankById(int Id)
        {
            return _db.bank.Find(Id); ;
        }
    }
}
