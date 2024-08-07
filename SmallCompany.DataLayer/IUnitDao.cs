using SmallCompany.Models;

namespace SmallCompany.DataLayer
{
    public interface IUnitDao
    {
        public List<Unit> GetUnitsFromSql();
        public void AddUnitToSql(Unit unit);
    }
}
