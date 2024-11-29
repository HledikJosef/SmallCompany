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
            stock.Name = StringModifier.ModifyString(stock.Name);
            stock.Location = StringModifier.ModifyString(stock.Location);
            stock.Description = StringModifier.ModifyString(stock.Description);

            return stockWriterDao.AddStockToDbAsync(stock);
        }

        public Task UpdateStockAsync(Stock stock)
        {
            stock.Name = StringModifier.ModifyString(stock.Name);
            stock.Location = StringModifier.ModifyString(stock.Location);
            stock.Description = StringModifier.ModifyString(stock.Description);

            return stockWriterDao.UpdateStockInDbAsync(stock);
        }

    }
}
