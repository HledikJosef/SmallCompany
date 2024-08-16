using SmallCompany.ClientBlazorIdentity.ModelsBlazor;
using SmallCompany.ServiceLayer.ModelsService;

namespace SmallCompany.ClientBlazorIdentity.Mappers
{
    public static class DateTypeMapper
    {
        public static BlazorDateType MapServiceBlazorDateType(ServiceDateType serviceDateType)
        {
            BlazorDateType blazorDateType = new BlazorDateType();

            blazorDateType.Id = serviceDateType.Id;
            blazorDateType.Name = serviceDateType.Name;

            return blazorDateType;
        }

        public static ServiceDateType MapBlazorServiceDateType(BlazorDateType blazorDateType)
        {
            ServiceDateType serviceDateType = new ServiceDateType();

            serviceDateType.Id = blazorDateType.Id;
            serviceDateType.Name = blazorDateType.Name;

            return serviceDateType;
        }

    }
}
