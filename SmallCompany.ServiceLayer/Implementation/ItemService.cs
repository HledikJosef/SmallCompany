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

        public async Task<Item?> CheckItemDuplicityAsync(Item item)
        {
            item.Name = StringModifier.ModifyString(item.Name);
            item.ItemPropertyValues.RemoveAll(ipv => string.IsNullOrWhiteSpace(ipv.Value));

            foreach (var ipv in item.ItemPropertyValues)
            {
                ipv.Value = StringModifier.ModifyString(ipv);
            }

            Item? existingItemFromDb = await itemDao.CheckExistingItemAsync(item);

            return existingItemFromDb;

        }

        public Task UpdateItemAsync(Item item)
        {
            item.Name = StringModifier.ModifyString(item.Name);
            item.ItemPropertyValues.RemoveAll(ipv => string.IsNullOrWhiteSpace(ipv.Value));

            foreach (var ipv in item.ItemPropertyValues)
            {
                string ipvValue = StringModifier.ModifyString(ipv.Value);
                ipv.Value = ipvValue;
            }

            return itemDao.UpdateItemInDbAsync(item);
        }



    }
}
