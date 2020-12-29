using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankSystem.Data;

namespace BankSystem.IService
{
   public interface ICurrencyService
    {
        Task<List<Currency>> GetCurrencies();
        Task<bool> AddCurrency(Currency newCurrency);
        Task<bool> UpdateCurrency(Currency updateCurrency);
        Task<bool> DeleteCurrency(Currency deleteCurrency);
        Currency GeCurrencyById(int Id);
    }
}
