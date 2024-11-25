using SmallCompany.DataLayer;
using SmallCompany.Models;

namespace SmallCompany.ServiceLayer.Implementation
{
    public class DateTypeService : IDateTypeService
    {
        private readonly IDateTypeDao dateTypeDao;

        public DateTypeService(IDateTypeDao dateTypeDao)
        {
            this.dateTypeDao = dateTypeDao;
        }

        public async Task<List<DateType>> GetDateTypesFromDaoAsync()
        {
            List<DateType> dateTypesFromDb = new List<DateType>();
            dateTypesFromDb = await dateTypeDao.GetDateTypesFromDbAsync();

            return dateTypesFromDb;

        }

        public Task AddDateTypeAsync(DateType dateType)
        {
            return dateTypeDao.AddDateTypeToDbAsync(dateType);
        }

        public Task UpdateDateTypeAsync(DateType dateType)
        {
            return dateTypeDao.UpdateDateTypeInDbAsync(dateType);
        }

        public Task DeleteDateTypeAsync(DateType dateType)
        {
            return dateTypeDao.DeleteDateTypeAsync(dateType);
        }
    }
}
