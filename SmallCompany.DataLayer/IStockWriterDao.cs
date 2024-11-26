using SmallCompany.Models;

namespace SmallCompany.DataLayer
{
    public interface IStockWriterDao
    {
        public Task AddStockToDbAsync(Stock stock);
        public Task UpdateStockInDbAsync(Stock stock);
    }
}
