using SmallCompany.ClientBlazorIdentity.ModelsBlazor;
using SmallCompany.Models;

namespace SmallCompany.ClientBlazorIdentity.Mappers
{
    public static class ItemPropertyValueMapper
    {
        public static ItemPropertyValue MapItemPropValue(BlazorProperty blazorProperty) //by New Item
        {
            ItemPropertyValue itemPropertyValue = new ItemPropertyValue();

            itemPropertyValue.Value = blazorProperty.Value;
            itemPropertyValue.PropertyId = blazorProperty.Id;
            //ItemId se doplní po uložení Item do SQL.

            return itemPropertyValue;
        }

        public static ItemPropertyValue MapItemPropValue(BlazorItemPropertyValue blazorItemPropertyValue) // by ItemUpdate
        {
            ItemPropertyValue itemPropertyValue = new ItemPropertyValue();

            itemPropertyValue.Id = blazorItemPropertyValue.Id;
            itemPropertyValue.Value = blazorItemPropertyValue.Value;
            itemPropertyValue.ItemId = blazorItemPropertyValue.BlazorItemId;
            itemPropertyValue.PropertyId = blazorItemPropertyValue.BlazorPropertyId;
            itemPropertyValue.Property = PropertyMapper.MapProperty(blazorItemPropertyValue.BlazorProperty);

            return itemPropertyValue;
        }

        public static BlazorItemPropertyValue MapItemPropValue(ItemPropertyValue itemPropertyValue)
        {
            BlazorItemPropertyValue blazorItemPropertyValue = new BlazorItemPropertyValue();
            blazorItemPropertyValue.Id = itemPropertyValue.Id;
            blazorItemPropertyValue.Value = itemPropertyValue.Value;
            blazorItemPropertyValue.BlazorItemId = itemPropertyValue.ItemId;
            blazorItemPropertyValue.BlazorPropertyId = itemPropertyValue.PropertyId;
            blazorItemPropertyValue.BlazorProperty = PropertyMapper.MapProperty(itemPropertyValue.Property);

            return blazorItemPropertyValue;
        }

    }
}
