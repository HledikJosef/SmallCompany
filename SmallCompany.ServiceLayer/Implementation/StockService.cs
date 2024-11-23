using SmallCompany.DataLayer;
using SmallCompany.Models;

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

        public async Task<List<Stock>> GetStocksFromDaoAsync()
        {
            List<Stock> stocksFromDb = new List<Stock>();
            stocksFromDb = await stockReaderDao.GetStocksFromDbAsync();

            return stocksFromDb;
        }

        public Task AddStockAsync(Stock stock)
        {
            return stockWriterDao.AddStockToDbAsync(stock);
        }
    }
}
