using SmallCompany.ServiceLayer.ModelsService;

namespace SmallCompany.ServiceLayer
{
    public interface ITypeOfItemService
    {
        public Task<List<ServiceTypeOfItem>> GetTypesOfItemsFromDao();
        public Task AddTypeOfItem(ServiceTypeOfItem serviceTypeOfItem);

    }
}
