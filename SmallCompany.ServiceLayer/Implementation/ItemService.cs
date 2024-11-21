using SmallCompany.DataLayer;
using SmallCompany.Models;
using SmallCompany.ServiceLayer.Mappers;
using SmallCompany.ServiceLayer.ModelsService;

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
            List<Item> itemsFromDao = new List<Item>();
            itemsFromDao = await itemDao.GetItemsFromSqlAsync();

            List<ServiceItem> serviceItemsFromDao = new List<ServiceItem>();

            return itemsFromDao;
        }

        public Task AddItemWithPropertiesAsync(ServiceItem serviceItem)
        {
            Item item = new Item();

            item = ServiceItemMapper.MapServiceItemToDao(serviceItem);
            item.ItemPropertyValues = serviceItem.ServiceItemPropertyValues.Select(x => ServiceItemPropValueMapper.MapItemPropertyValueToDao(x)).ToList();

            return itemDao.AddItemWithPropertiesToDbAsync(item);
        }

        public async Task<List<ServiceItem>> CheckItemDuplicityAsync(ServiceItem serviceItem)
        {
            Item item = new Item();

            item = ServiceItemMapper.MapServiceItemToDao(serviceItem);
            item.ItemPropertyValues = serviceItem.ServiceItemPropertyValues.Select(x => ServiceItemPropValueMapper.MapItemPropertyValueToDao(x)).ToList();

            List<Item> existingItemsFromDao = await itemDao.CheckExistingItemAsync(item);
            List<ServiceItem> existingServiceItems = existingItemsFromDao.Select(x => ServiceItemMapper.MapServiceItemFromDao(x)).ToList();

            return existingServiceItems;

        }




    }
}
