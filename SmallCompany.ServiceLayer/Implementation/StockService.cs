using SmallCompany.DataLayer;
using SmallCompany.Models;
using SmallCompany.ServiceLayer.Mappers;
using SmallCompany.ServiceLayer.ModelsService;

namespace SmallCompany.ServiceLayer.Implementation
{
    public class StockService : IStockService
    {
        private readonly IStockReaderDao stockReaderDao;
        private readonly IStockWriterDao stockWriterDao;

        public StockService(IStockReaderDao stockReaderDao, IStockWriterDao stockWriterDao)
        {
            this.stockReaderDao = stockReaderDao;
            this.stockWriterDao = stockWriterDao;
        }

        public async Task<List<ServiceStock>> GetStocksFromDao()
        {
            List<Stock> stocksFromSql = new List<Stock>();
            stocksFromSql = await stockReaderDao.GetStocksFromDbAsync();

            List<ServiceStock> serviceStocks = new List<ServiceStock>();
            serviceStocks = stocksFromSql.Select(stock => ServiceStockMapper.MapServiceStockFromDao(stock)).ToList();

            return serviceStocks;
        }

        public Task AddStock(ServiceStock serviceStock)
        {
            Stock stock = new Stock();
            stock = ServiceStockMapper.MapServiceStockToDao(serviceStock);

            return stockWriterDao.AddStockToDbAsync(stock);
        }
    }
}
