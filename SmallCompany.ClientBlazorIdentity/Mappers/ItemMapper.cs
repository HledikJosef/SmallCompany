﻿using SmallCompany.ClientBlazorIdentity.ModelsBlazor;
using SmallCompany.Models;

namespace SmallCompany.ClientBlazorIdentity.Mappers
{
    public static class ItemMapper
    {
        public static Item MapItem(BlazorItem blazorItem)
        {
            Item item = new Item();

            item.Id = blazorItem.Id;
            item.Name = blazorItem.Name;
            item.UnitId = blazorItem.UnitId;
            item.TypeOfItemId = blazorItem.TypeOfItemId;
            item.IsActive = blazorItem.IsActive;

            return item;
        }

        public static BlazorItem MapItem(Item item)
        {
            BlazorItem blazorItem = new BlazorItem();

            blazorItem.Id = item.Id;
            blazorItem.Name = item.Name;
            blazorItem.UnitId = item.UnitId;
            blazorItem.TypeOfItemId = item.TypeOfItemId;
            blazorItem.BlazorUnit = UnitMapper.MapUnit(item.Unit);
            blazorItem.BlazorTypeOfItem = TypeOfItemMapper.MapTypeOfItem(item.TypeOfItem);
            blazorItem.BlazorItemPropertyValues = item.ItemPropertyValues.Select(x => ItemPropertyValueMapper.MapItemPropValue(x)).ToList();
            blazorItem.IsActive = item.IsActive;

            return blazorItem;
        }
    }
}
