using SmallCompany.Models;

namespace SmallCompany.DataLayer
{
    public interface IUnitModelDao
    {
        public List<UnitModel> ReadUnits();
        public List<UnitModel> ReadUnitsEF();
    }
}
