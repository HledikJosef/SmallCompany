using SmallCompany.Models;

namespace SmallCompany.ServiceLayer
{
    public interface IItemService
    {
        public Task<List<Item>> GetItemsFromDaoAsync();
        public Task AddItemWithPropertiesAsync(Item item);
        public Task<List<Item>> CheckItemDuplicityAsync(Item item);

    }
}
