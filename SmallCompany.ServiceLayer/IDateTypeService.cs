using SmallCompany.ServiceLayer.ModelsService;

namespace SmallCompany.ServiceLayer
{
    public interface IDateTypeService
    {
        public Task<List<ServiceDateType>> GetDateTypesFromDaoAsync();
        public Task AddDateTypeAsync(ServiceDateType serviceDateType);
    }
}
