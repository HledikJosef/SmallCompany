using SmallCompany.Models;

namespace SmallCompany.DataLayer
{
    public interface IDateTypeDao
    {
        public List<DateType> GetDateTypesFromSql();

        public void AddDateTypeToSql(DateType dateType);

    }
}
