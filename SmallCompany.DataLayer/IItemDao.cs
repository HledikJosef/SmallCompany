using SmallCompany.Models;

namespace SmallCompany.DataLayer
{
    public interface IItemDao
    {
        public Task<List<Item>> GetItemsFromSqlAsync();
        public Task AddItemWithPropertiesToDbAsync(Item itemWithProperties);

        public Task<List<Item>> CheckExistingItemAsync(Item item);

    }
}
