using SmallCompany.DataLayer;
using SmallCompany.Models;

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

        public async Task<List<Unit>> GetUnitsFromDaoAsync()
        {
            List<Unit> unitsFromDb = new List<Unit>();
            unitsFromDb = await unitReaderDao.GetUnitsFromDbAsync();

            return unitsFromDb;
        }

        public Task AddUnitAsync(Unit unit)
        {
            return unitWriterDao.AddUnitToDbAsync(unit);
        }
    }
}
