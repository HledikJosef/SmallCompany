using SmallCompany.DataLayer;
using SmallCompany.Models;

namespace SmallCompany.ServiceLayer.Implementation
{
    public class ItemService : IItemService
    {
        private readonly IItemDao itemDao;

        public ItemService(IItemDao itemDao)
        {
            this.itemDao = itemDao;
        }

        public async Task<List<Item>> GetItemsFromDaoAsync()
        {
            List<Item> itemsFromDb = new List<Item>();
            itemsFromDb = await itemDao.GetItemsFromSqlAsync();

            return itemsFromDb;
        }

        public Task AddItemWithPropertiesAsync(Item item)
        {
            return itemDao.AddItemWithPropertiesToDbAsync(item);
        }

        public async Task<List<int>> CheckItemDuplicityAsync(Item item)
        {
            List<int> existingItemsFromDb = await itemDao.CheckExistingItemAsync(item);

            return existingItemsFromDb;

        }




    }
}
