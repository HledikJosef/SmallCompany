using SmallCompany.ClientBlazorIdentity.ModelsBlazor;
using SmallCompany.Models;

namespace SmallCompany.ClientBlazorIdentity.Mappers
{
    public class DateTypeMapper
    {
        public static DateType MapDateType(BlazorDateType blazorDateType)
        {
            DateType dateType = new DateType();
            dateType.Id = blazorDateType.Id;
            dateType.Name = blazorDateType.Name;
            dateType.IsActive = blazorDateType.IsActive;

            return dateType;
        }

        public static BlazorDateType MapDateType(DateType dateType)
        {
            BlazorDateType blazorDateType = new BlazorDateType();
            blazorDateType.Id = dateType.Id;
            blazorDateType.Name = dateType.Name;
            blazorDateType.IsActive = dateType.IsActive;

            return blazorDateType;
        }
    }
}
