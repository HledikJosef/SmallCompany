using SmallCompany.DataLayer;
using SmallCompany.Models;
using SmallCompany.ServiceLayer.Mappers;
using SmallCompany.ServiceLayer.ModelsService;

namespace SmallCompany.ServiceLayer.Implementation
{
    public class DateTypeService : IDateTypeService
    {
        private readonly IDateTypeDao dateTypeDao;

        public DateTypeService(IDateTypeDao dateTypeDao)
        {
            this.dateTypeDao = dateTypeDao;
        }

        public async Task<List<ServiceDateType>> GetDateTypesFromDao()
        {
            List<DateType> dateTypesFromDb = new List<DateType>();
            dateTypesFromDb = await dateTypeDao.GetDateTypesFromDbAsync();

            List<ServiceDateType> serviceDateTypesFromDb = new List<ServiceDateType>();
            serviceDateTypesFromDb = dateTypesFromDb.Select(dateType => ServiceDateTypeMapper.MapServiceDateTypFromDao(dateType)).ToList();

            return serviceDateTypesFromDb;

        }

        public Task AddDateType(ServiceDateType serviceDateType)
        {
            DateType dateType = new DateType();
            dateType = ServiceDateTypeMapper.MapServiceDateTypToDao(serviceDateType);

            return dateTypeDao.AddDateTypeToDbAsync(dateType);
        }
    }
}
