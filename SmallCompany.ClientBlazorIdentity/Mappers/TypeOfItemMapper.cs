using SmallCompany.ClientBlazorIdentity.ModelsBlazor;
using SmallCompany.Models;

namespace SmallCompany.ClientBlazorIdentity.Mappers
{
    public static class TypeOfItemMapper
    {
        public static BlazorTypeOfItem MapTypeOfItem(TypeOfItem typeOfItem)
        {
            BlazorTypeOfItem blazorTypeOfItem = new BlazorTypeOfItem();

            blazorTypeOfItem.Id = typeOfItem.Id;
            blazorTypeOfItem.Name = typeOfItem.Name;
            blazorTypeOfItem.IsActive = typeOfItem.IsActive;

            return blazorTypeOfItem;
        }

        public static TypeOfItem MapTypeOfItem(BlazorTypeOfItem blazorTypeOfItem)
        {
            TypeOfItem typeOfItem = new TypeOfItem();

            typeOfItem.Id = blazorTypeOfItem.Id;
            typeOfItem.Name = blazorTypeOfItem.Name;
            typeOfItem.IsActive = blazorTypeOfItem.IsActive;

            return typeOfItem;
        }
    }
}
