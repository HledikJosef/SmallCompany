using SmallCompany.DataLayer.Implementation;
using SmallCompany.Models;
using SmallCompany.ServiceLayer.ModelsBlazor;

namespace SmallCompany.ServiceLayer.Implementation
{
    public class UnitService : IUnitService
    {
        private UnitDao UnitDao { get; set; } = new UnitDao();
        public List<ServiceUnit> GetUnitsFromDao()
        {
            List<Unit> unitsFromSql = new List<Unit>();
            unitsFromSql = UnitDao.GetUnitsFromSql();


        }
    }
}
