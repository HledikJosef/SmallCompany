using SmallCompany.Models;
using SmallCompany.ServiceLayer.ModelsService;

namespace SmallCompany.ServiceLayer.Mappers
{
	public static class ServiceItemPropValueMapper
	{
		public static ServiceItemPropertyValue MapItemPropertyValueFromDao(ItemPropertyValue itemPropertyValue)
		{
			ServiceItemPropertyValue serviceItemPropertyValue = new ServiceItemPropertyValue();

			serviceItemPropertyValue.Id = itemPropertyValue.Id;
			serviceItemPropertyValue.Value = itemPropertyValue.Value;
			serviceItemPropertyValue.ServiceItemId = itemPropertyValue.ItemId;
			serviceItemPropertyValue.ServicePropertyId = itemPropertyValue.PropertyId;
			serviceItemPropertyValue.ServiceItem = ServiceItemMapper.MapServiceItemFromDao(itemPropertyValue.Item);
			serviceItemPropertyValue.ServiceProperty = ServicePropertyMapper.MapServicePropertyFromDao(itemPropertyValue.Property);

			return serviceItemPropertyValue;

		}

		public static ItemPropertyValue MapItemPropertyValueToDao(ServiceItemPropertyValue serviceItemPropertyValue)
		{
			ItemPropertyValue itemPropertyValue = new ItemPropertyValue();
			itemPropertyValue.Id = serviceItemPropertyValue.Id;
			itemPropertyValue.Value = serviceItemPropertyValue.Value;
			itemPropertyValue.ItemId = serviceItemPropertyValue.ServiceItemId;
			itemPropertyValue.PropertyId = serviceItemPropertyValue.ServicePropertyId;

			return itemPropertyValue;
		}
	}
}
