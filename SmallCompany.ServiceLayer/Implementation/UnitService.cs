using SmallCompany.DataLayer;
using SmallCompany.Models;
using SmallCompany.ServiceLayer.Mappers;
using SmallCompany.ServiceLayer.ModelsBlazor;

namespace SmallCompany.ServiceLayer.Implementation
{
    public class UnitService : IUnitService
    {
        private readonly IUnitDao unitDao;

        public UnitService(IUnitDao unitDao)
        {
            this.unitDao = unitDao;
        }
        public List<ServiceUnit> GetUnitsFromDao()
        {
            List<Unit> unitsFromSql = new List<Unit>();
            unitsFromSql = unitDao.GetUnitsFromSql();

            List<ServiceUnit> serviceUnits = new List<ServiceUnit>();
            serviceUnits = unitsFromSql.Select(unit => ServiceUnitMapper.MapServiceUnitsFromDao(unit)).ToList();

            return serviceUnits;
        }
    }
}
