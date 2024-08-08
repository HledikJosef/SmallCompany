using SmallCompany.Models;

namespace SmallCompany.DataLayer
{
    public interface IStockReaderDao
    {
        public Task<List<Stock>> GetStocksFromDbAsync();
    }
}
