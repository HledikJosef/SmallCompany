using SmallCompany.DataLayer;
using SmallCompany.Models;

namespace SmallCompany.ServiceLayer.Implementation
{
    public class CurrencyService : ICurrencyService
    {
        private readonly ICurrencyDao currencyDao;

        public CurrencyService(ICurrencyDao currencyDao)
        {
            this.currencyDao = currencyDao;
        }

        public async Task<List<Currency>> GetCurrenciesFromDaoAsync()
        {
            List<Currency> currenciesFromDao = new List<Currency>();
            currenciesFromDao = await currencyDao.GetCurrenciesFromDbAsync();

            return currenciesFromDao;
        }
    }
}
