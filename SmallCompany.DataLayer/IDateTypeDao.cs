using SmallCompany.Models;

namespace SmallCompany.DataLayer
{
    public interface IDateTypeDao
    {
        public Task<List<DateType>> GetDateTypesFromDbAsync();
        public Task AddDateTypeToDbAsync(DateType dateType);
        public Task UpdateDateTypeInDbAsync(DateType dateType);
        public Task<DateType> CheckDateTypeDuplicity(DateType dateTypeToCheck);

    }
}
