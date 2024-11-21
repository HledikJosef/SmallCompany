using SmallCompany.ServiceLayer.ModelsService;

namespace SmallCompany.ServiceLayer
{
    public interface ITypeOfItemService
    {
        public Task<List<ServiceTypeOfItem>> GetTypesOfItemsFromDaoAsync();
        public Task AddTypeOfItemAsync(ServiceTypeOfItem serviceTypeOfItem);

    }
}
