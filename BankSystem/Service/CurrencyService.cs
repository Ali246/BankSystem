using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankSystem.Data;
using BankSystem.IService;
using Microsoft.EntityFrameworkCore;

namespace BankSystem.Service
{
    public class CurrencyService : ICurrencyService
    {
        private readonly ApplicationDbContext _db;
        public CurrencyService(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<List<Currency>> GetCurrencies()
        {
            return await _db.currency.Where(x => x.IsDeleted == false).ToListAsync();
        }
        public async Task<bool> AddCurrency(Currency newCurrency)
        {
            newCurrency.IsDeleted = false;
            newCurrency.CreateDate = DateTime.Now;
            await _db.currency.AddAsync(newCurrency);
            _db.SaveChanges();
            return true;
        }
        public async Task<bool> UpdateCurrency(Currency updateCurrency)
        {
            updateCurrency.modifiedDate = DateTime.Now;
            _db.currency.Update(updateCurrency);
            await _db.SaveChangesAsync();
            return true;
        }
        public async Task<bool> DeleteCurrency(Currency deleteCurrency)
        {
            _db.currency.Update(deleteCurrency);
            await _db.SaveChangesAsync();
            return true;
        }
        public Currency GeCurrencyById(int Id)
        {
            return _db.currency.Find(Id); ;
        }
    }
}
