using SmallCompany.ClientBlazorIdentity.ModelsBlazor;
using SmallCompany.Models;

namespace SmallCompany.ClientBlazorIdentity.Mappers
{
    public static class ItemToUpdateMapper
    {
        public static Item MapItemToUpdate(BlazorItemToUpdate blazorItemToUpdate)
        {
            Item item = new Item();

            item.Id = blazorItemToUpdate.Id;
            item.Name = blazorItemToUpdate.Name;
            item.UnitId = blazorItemToUpdate.UnitId;
            item.TypeOfItemId = blazorItemToUpdate.TypeOfItemId;
            item.IsActive = blazorItemToUpdate.IsActive;
            item.ItemPropertyValues = blazorItemToUpdate.BlazorItemPropertyValues.Select(ipv => ItemPropertyValueMapper.MapItemPropValue(ipv)).ToList();

            return item;
        }

        public static BlazorItemToUpdate MapItemToUpdate(Item item)
        {
            BlazorItemToUpdate itemToUpdate = new BlazorItemToUpdate();
            itemToUpdate.Id = item.Id;
            itemToUpdate.Name = item.Name;
            itemToUpdate.UnitId = item.UnitId;
            itemToUpdate.TypeOfItemId = item.TypeOfItemId;
            itemToUpdate.IsActive = item.IsActive;
            itemToUpdate.BlazorItemPropertyValues = item.ItemPropertyValues.Select(ipv => ItemPropertyValueMapper.MapItemPropValue(ipv)).ToList();
            itemToUpdate.BlazorTypeOfItem = TypeOfItemMapper.MapTypeOfItem(item.TypeOfItem);
            itemToUpdate.BlazorUnit = UnitMapper.MapUnit(item.Unit);

            return itemToUpdate;
        }


        //public static BlazorItemToUpdate MapItemToUpdate(BlazorItemNew blazorItem)
        //{
        //    BlazorItemToUpdate blazorItemtoUpdate = new();

        //    blazorItemtoUpdate.Id = blazorItem.Id;
        //    blazorItemtoUpdate.Name = blazorItem.Name;
        //    blazorItemtoUpdate.UnitId = blazorItem.UnitId;
        //    blazorItemtoUpdate.TypeOfItemId = blazorItem.TypeOfItemId;
        //    blazorItemtoUpdate.IsActive = blazorItem.IsActive;
        //    blazorItemtoUpdate.BlazorItemPropertyValues = blazorItem.BlazorItemPropertyValues;

        //    return blazorItemtoUpdate;
        //}
    }
}
