using SmallCompany.Models;

namespace SmallCompany.ServiceLayer
{
    public interface IUnitService
    {
        public Task<List<Unit>> GetUnitsFromDaoAsync();
        public Task AddUnitAsync(Unit unit);
    }
}
