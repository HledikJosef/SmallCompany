using SmallCompany.ClientBlazorIdentity.ModelsBlazor;
using SmallCompany.Models;

namespace SmallCompany.ClientBlazorIdentity.Mappers
{
    public static class ItemPropertyValueMapper
    {
        public static ItemPropertyValue MapItemPropValue(BlazorProperty blazorProperty)
        {
            ItemPropertyValue itemPropertyValue = new ItemPropertyValue();

            itemPropertyValue.Value = blazorProperty.Value;
            itemPropertyValue.PropertyId = blazorProperty.Id;
            //ItemId se doplní po uložení Item do SQL.

            return itemPropertyValue;
        }

        public static BlazorItemPropertyValue MapItemPropValue(ItemPropertyValue itemPropertyValue)
        {
            BlazorItemPropertyValue blazorItemPropertyValue = new BlazorItemPropertyValue();
            blazorItemPropertyValue.Value = itemPropertyValue.Value;
            blazorItemPropertyValue.BlazorItemId = itemPropertyValue.ItemId;
            blazorItemPropertyValue.BlazorPropertyId = itemPropertyValue.PropertyId;

            return blazorItemPropertyValue;
        }
    }
}
