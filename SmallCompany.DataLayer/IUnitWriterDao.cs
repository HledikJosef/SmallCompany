using SmallCompany.Models;

namespace SmallCompany.DataLayer
{
    public interface IUnitWriterDao
    {
        public Task AddUnitToDbAsync(Unit unit);
    }
}
