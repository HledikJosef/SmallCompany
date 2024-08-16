using SmallCompany.ServiceLayer.ModelsService;

namespace SmallCompany.ServiceLayer
{
    public interface IDateTypeService
    {
        public Task<List<ServiceDateType>> GetDateTypesFromDao();
        public Task AddDateType(ServiceDateType serviceDateType);
    }
}
