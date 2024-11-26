using SmallCompany.Models;

namespace SmallCompany.DataLayer
{
    public interface IUnitWriterDao
    {
        public Task AddUnitToDbAsync(Unit unit);
        public Task UpdateUnitInDbAsync(Unit unit);
    }
}
