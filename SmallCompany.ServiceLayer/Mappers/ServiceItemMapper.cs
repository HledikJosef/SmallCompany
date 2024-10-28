using SmallCompany.Models;
using SmallCompany.ServiceLayer.ModelsService;

namespace SmallCompany.ServiceLayer.Mappers
{
	public static class ServiceItemMapper
	{
		public static ServiceItem MapServiceItemFromDao(Item item)
		{
			ServiceItem serviceItem = new ServiceItem();
			serviceItem.Id = item.Id;
			serviceItem.Name = item.Name;
			serviceItem.UnitId = item.UnitId;
			serviceItem.TypeOfItemId = item.TypeOfItemId;
			serviceItem.ServiceUnit = ServiceUnitMapper.MapServiceUnitsFromDao(item.Unit);
			serviceItem.ServiceTypeOfItem = ServiceTypeOfItemMapper.MapServiceTypeOfItemFromDao(item.TypeOfItem);
			serviceItem.ServiceItemPropertyValues = item.ItemPropertyValues.Select(x => ServiceItemPropValueMapper.MapItemPropertyValueFromDao(x)).ToList();

			return serviceItem;
		}

		public static Item MapServiceItemToDao(ServiceItem serviceItem)
		{
			Item item = new Item();

			item.Id = serviceItem.Id;
			item.Name = serviceItem.Name;
			item.UnitId = serviceItem.UnitId;
			item.TypeOfItemId = serviceItem.TypeOfItemId;

			return item;
		}
	}
}
