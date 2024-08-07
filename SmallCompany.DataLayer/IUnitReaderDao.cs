using SmallCompany.Models;

namespace SmallCompany.DataLayer
{
    public interface IUnitReaderDao
    {
        public Task<List<Unit>> GetUnitsFromDbAsync();
    }
}
