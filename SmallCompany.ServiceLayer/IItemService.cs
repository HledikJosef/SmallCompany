using SmallCompany.Models;
using SmallCompany.ServiceLayer.ModelsService;

namespace SmallCompany.ServiceLayer
{
    public interface IItemService
    {
        public Task<List<Item>> GetItemsFromDaoAsync();
        public Task AddItemWithPropertiesAsync(ServiceItem serviceItem);
        public Task<List<int>> CheckItemDuplicityAsync(ServiceItem serviceItem);

    }
}
