using Microsoft.EntityFrameworkCore;
using SmallCompany.Models;
using SmallCompany.Models.Data;

namespace SmallCompany.DataLayer.Implementation
{
    public class UnitDao : IUnitReaderDao, IUnitWriterDao
    {
        private readonly ApplicationDbContext context;

        public UnitDao(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<List<Unit>> GetUnitsFromDbAsync()
        {
            List<Unit> unitsFromSql = new List<Unit>();
            unitsFromSql = await context.Units.ToListAsync();

            return unitsFromSql;
        }

        public async Task AddUnitToDbAsync(Unit unit)
        {
            await context.Units.AddAsync(unit);
        }
    }
}
