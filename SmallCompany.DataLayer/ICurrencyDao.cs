using SmallCompany.Models;

namespace SmallCompany.DataLayer
{
    public interface ICurrencyDao
    {
        public Task<List<Currency>> GetCurrenciesFromDbAsync();
    }
}
