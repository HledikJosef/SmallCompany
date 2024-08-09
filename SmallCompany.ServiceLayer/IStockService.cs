using SmallCompany.ServiceLayer.ModelsService;

namespace SmallCompany.ServiceLayer
{
    public interface IStockService
    {
        public Task<List<ServiceStock>> GetStocksFromDao();
        public Task AddStock(ServiceStock serviceStock);
    }
}
