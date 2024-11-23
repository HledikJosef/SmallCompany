using SmallCompany.Models;

namespace SmallCompany.ServiceLayer
{
    public interface IStockService
    {
        public Task<List<Stock>> GetStocksFromDaoAsync();
        public Task AddStockAsync(Stock stock);
    }
}
