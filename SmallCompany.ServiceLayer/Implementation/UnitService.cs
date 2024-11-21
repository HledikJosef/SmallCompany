using SmallCompany.DataLayer;
using SmallCompany.Models;
using SmallCompany.ServiceLayer.Mappers;
using SmallCompany.ServiceLayer.ModelsService;

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

        public async Task<List<ServiceUnit>> GetUnitsFromDaoAsync()
        {
            List<Unit> unitsFromSql = new List<Unit>();
            unitsFromSql = await unitReaderDao.GetUnitsFromDbAsync();

            List<ServiceUnit> serviceUnits = new List<ServiceUnit>();
            serviceUnits = unitsFromSql.Select(unit => ServiceUnitMapper.MapServiceUnitsFromDao(unit)).ToList();

            return serviceUnits;
        }

        public Task AddUnitAsync(ServiceUnit serviceUnit)
        {
            Unit unit = new Unit();
            unit = ServiceUnitMapper.MapServiceUnitsToDao(serviceUnit);

            return unitWriterDao.AddUnitToDbAsync(unit);
        }
    }
}
