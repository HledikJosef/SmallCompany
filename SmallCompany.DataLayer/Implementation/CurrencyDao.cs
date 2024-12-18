using Microsoft.EntityFrameworkCore;
using SmallCompany.Models;
using SmallCompany.Models.Data;

namespace SmallCompany.DataLayer.Implementation
{
    public class CurrencyDao : ICurrencyDao
    {
        private readonly ApplicationDbContext context;

        public CurrencyDao(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<List<Currency>> GetCurrenciesFromDbAsync()
        {
            List<Currency> currenciesFromSql = new List<Currency>();
            currenciesFromSql = await context.Currencies.ToListAsync();

            return currenciesFromSql;
        }


    }
}
