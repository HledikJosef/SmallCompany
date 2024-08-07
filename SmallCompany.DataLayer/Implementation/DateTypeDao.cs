using SmallCompany.Models;
using SmallCompany.Models.Data;

namespace SmallCompany.DataLayer.Implementation
{
    public class DateTypeDao : IDateTypeDao
    {
        private readonly ApplicationDbContext context;

        public DateTypeDao(ApplicationDbContext context)
        {
            this.context = context;
        }

        public List<DateType> GetDateTypesFromSql()
        {
            List<DateType> dateTypesFromSql = new List<DateType>();
            dateTypesFromSql = context.DateTypes.ToList();

            return dateTypesFromSql;
        }

        public void AddDateTypeToSql(DateType dateType)
        {
            context.DateTypes.Add(dateType);
        }
    }
}
