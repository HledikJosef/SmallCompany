using SmallCompany.Models;

namespace SmallCompany.DataLayer
{
    public interface IDateTypeDao
    {
        public List<Unit> GetUnitsFromSql();
        public void AddUnitToSql(Unit unit);

    }
}
