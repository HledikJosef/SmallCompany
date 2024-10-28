using SmallCompany.ClientBlazorIdentity.ModelsBlazor;
using SmallCompany.ServiceLayer.ModelsService;

namespace SmallCompany.ClientBlazorIdentity.Mappers
{
	public static class ItemPropertyValueMapper
	{
		public static ServiceItemPropertyValue MapItemPropValue(BlazorProperty blazorProperty)
		{
			ServiceItemPropertyValue serviceItemPropertyValue = new ServiceItemPropertyValue();

			serviceItemPropertyValue.Value = blazorProperty.Value;
			serviceItemPropertyValue.ServicePropertyId = blazorProperty.Id;
			//ServiceItemId se doplní v servisní vrstvě, až bude známo po uložení Item do SQL.

			return serviceItemPropertyValue;
		}
	}
}
