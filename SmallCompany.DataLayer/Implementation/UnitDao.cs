using SmallCompany.Models;
using SmallCompany.Models.Data;

namespace SmallCompany.DataLayer.Implementation
{
    public class UnitDao : IUnitDao
    {
        private readonly ApplicationDbContext context;

        public UnitDao(ApplicationDbContext context)
        {
            this.context = context;
        }

        public List<Unit> GetUnitsFromSql()
        {
            List<Unit> unitsFromSql = new List<Unit>();
            unitsFromSql = context.Units.ToList();

            return unitsFromSql;

        }

        public void AddUnitToSql(Unit unit)
        {
            context.Units.Add(unit);
        }
    }
}
