using SmallCompany.DataLayer.Implementation;
using SmallCompany.Models;
using SmallCompany.ServiceLayer.Mappers;
using SmallCompany.ServiceLayer.ModelsService;

namespace SmallCompany.ServiceLayer.Implementation
{
    public class StockService : IStockService
    {
        private readonly StockDao stockDao;

        public StockService(StockDao stockDao)
        {
            this.stockDao = stockDao;
        }

        public List<ServiceStock> GetStocksFromDao()
        {
            List<Stock> stocksFromSql = new List<Stock>();
            stocksFromSql = stockDao.GetStocksFromDbAsync().GetAwaiter().GetResult();

            List<ServiceStock> serviceStocks = new List<ServiceStock>();
            serviceStocks = stocksFromSql.Select(stock => ServiceStockMapper.MapServiceStockFromDao(stock)).ToList();

            return serviceStocks;
        }

        public Task AddStock(ServiceStock serviceStock)
        {
            Stock stock = new Stock();
            stock = ServiceStockMapper.MapServiceStockToDao(serviceStock);

            return stockDao.AddStockToDbAsync(stock);
        }
    }
}
