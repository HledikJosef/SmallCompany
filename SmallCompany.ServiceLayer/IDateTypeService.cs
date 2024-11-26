using SmallCompany.Models;

namespace SmallCompany.ServiceLayer
{
    public interface IDateTypeService
    {
        public Task<List<DateType>> GetDateTypesFromDaoAsync();
        public Task AddDateTypeAsync(DateType dateType);
        public Task UpdateDateTypeAsync(DateType dateType);
        public Task<DateType> CheckDateTypeDuplicityAsync(DateType dateType);

    }
}
