using SmallCompany.ClientBlazorIdentity.ModelsBlazor;
using SmallCompany.ServiceLayer.ModelsService;

namespace SmallCompany.ClientBlazorIdentity.Mappers
{
    public static class ItemPropertyValueMapper
    {
        public static ServiceItemPropertyValue MapBlazorServiceItemPropValue(BlazorProperty blazorProperty)
        {
            ServiceItemPropertyValue serviceItemPropertyValue = new ServiceItemPropertyValue();

            serviceItemPropertyValue.Value = blazorProperty.Value;
            serviceItemPropertyValue.ServicePropertyId = blazorProperty.Id;
            //ServiceItemId se doplní v servisní vrstvě, až bude známo po uložení Item do SQL.

            return serviceItemPropertyValue;
        }

        public static BlazorItemPropertyValue MapServiceBlazorItemPropValue(ServiceItemPropertyValue serviceItemPropertyValue)
        {
            BlazorItemPropertyValue blazorItemPropertyValue = new BlazorItemPropertyValue();
            blazorItemPropertyValue.Value = serviceItemPropertyValue.Value;
            blazorItemPropertyValue.BlazorItemId = serviceItemPropertyValue.ServiceItemId;
            blazorItemPropertyValue.BlazorPropertyId = serviceItemPropertyValue.ServicePropertyId;

            return blazorItemPropertyValue;
        }
    }
}
