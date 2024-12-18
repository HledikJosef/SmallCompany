using SmallCompany.Models;

namespace SmallCompany.ServiceLayer
{
    public interface ICurrencyService
    {
        public Task<List<Currency>> GetCurrenciesFromDaoAsync();
    }
}
