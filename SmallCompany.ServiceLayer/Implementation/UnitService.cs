using SmallCompany.DataLayer;
using SmallCompany.Models;
using SmallCompany.ServiceLayer.Mappers;
using SmallCompany.ServiceLayer.ModelsBlazor;

namespace SmallCompany.ServiceLayer.Implementation
{
    public class UnitService : IUnitService
    {
        private readonly IUnitReaderDao unitReaderDao;
        private readonly IUnitWriterDao unitWriterDao;

        public UnitService(IUnitReaderDao unitReaderDao, IUnitWriterDao unitWriterDao)
        {
            this.unitReaderDao = unitReaderDao;
            this.unitWriterDao = unitWriterDao;
        }

        public List<ServiceUnit> GetUnitsFromDao()
        {
            List<Unit> unitsFromSql = new List<Unit>();
            unitsFromSql = unitReaderDao.GetUnitsFromDbAsync().GetAwaiter().GetResult(); //bridge mezi neasynchroní a asynchroní metodou!!

            List<ServiceUnit> serviceUnits = new List<ServiceUnit>();
            serviceUnits = unitsFromSql.Select(unit => ServiceUnitMapper.MapServiceUnitsFromDao(unit)).ToList();

            return serviceUnits;
        }

        public void AddUnit(ServiceUnit serviceUnit)
        {
            Unit unit = new Unit();
            unit = ServiceUnitMapper.MapServiceUnitsToDao(serviceUnit);

            unitWriterDao.AddUnitToDbAsync(unit);

        }
    }
}
