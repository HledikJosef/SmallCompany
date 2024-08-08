using SmallCompany.DataLayer.Implementation;
using SmallCompany.Models;
using SmallCompany.ServiceLayer.Mappers;
using SmallCompany.ServiceLayer.ModelsService;

namespace SmallCompany.ServiceLayer.Implementation
{
    public class UnitService : IUnitService
    {
        private readonly UnitDao unitDao;

        public UnitService(UnitDao unitDao)
        {
            this.unitDao = unitDao;
        }

        public List<ServiceUnit> GetUnitsFromDao()
        {
            List<Unit> unitsFromSql = new List<Unit>();
            unitsFromSql = unitDao.GetUnitsFromDbAsync().GetAwaiter().GetResult(); //bridge mezi neasynchroní a asynchroní metodou!!

            List<ServiceUnit> serviceUnits = new List<ServiceUnit>();
            serviceUnits = unitsFromSql.Select(unit => ServiceUnitMapper.MapServiceUnitsFromDao(unit)).ToList();

            return serviceUnits;
        }

        public Task AddUnit(ServiceUnit serviceUnit)
        {
            Unit unit = new Unit();
            unit = ServiceUnitMapper.MapServiceUnitsToDao(serviceUnit);

            return unitDao.AddUnitToDbAsync(unit);

        }
    }
}
