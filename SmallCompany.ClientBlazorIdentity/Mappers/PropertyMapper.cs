using SmallCompany.ClientBlazorIdentity.ModelsBlazor;
using SmallCompany.Models;

namespace SmallCompany.ClientBlazorIdentity.Mappers
{
    public static class PropertyMapper
    {
        public static BlazorProperty MapProperty(Property property)
        {
            BlazorProperty blazorProperty = new BlazorProperty();
            blazorProperty.Id = property.Id;
            blazorProperty.Name = property.Name;
            blazorProperty.BlazorDateTypeId = property.DateTypeId;
            blazorProperty.IsActive = property.IsActive;
            blazorProperty.BlazorDateType = DateTypeMapper.MapDateType(property.DateType);

            return blazorProperty;

        }

        public static Property MapProperty(BlazorProperty blazorProperty)
        {
            Property property = new Property();
            property.Id = blazorProperty.Id;
            property.Name = blazorProperty.Name;
            property.DateTypeId = blazorProperty.BlazorDateTypeId;
            property.IsActive = blazorProperty.IsActive;
            property.DateType = DateTypeMapper.MapDateType(blazorProperty.BlazorDateType);

            return property;
        }
    }
}
