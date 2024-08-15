using Microsoft.EntityFrameworkCore;
using SmallCompany.Models;
using SmallCompany.Models.Data;

namespace SmallCompany.DataLayer.Implementation
{
    public class StockDao : IStockReaderDao, IStockWriterDao
    {
        private readonly ApplicationDbContext context;

        public StockDao(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<List<Stock>> GetStocksFromDbAsync()
        {
            List<Stock> stocksFromDb = new List<Stock>();
            stocksFromDb = await context.Stocks.ToListAsync();

            return stocksFromDb;

        }

        public async Task AddStockToDbAsync(Stock stock)
        {
            await context.Stocks.AddAsync(stock);
            await context.SaveChangesAsync();
        }
    }
}
