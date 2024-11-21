using SmallCompany.ServiceLayer.ModelsService;

namespace SmallCompany.ServiceLayer
{
    public interface IStockService
    {
        public Task<List<ServiceStock>> GetStocksFromDaoAsync();
        public Task AddStockAsync(ServiceStock serviceStock);
    }
}
