using SmallCompany.ClientBlazorIdentity.ModelsBlazor;
using SmallCompany.ServiceLayer.ModelsBlazor;

namespace SmallCompany.ClientBlazorIdentity.Mappers
{
    public static class UnitMapper
    {
        public static BlazorUnit MapServiceBlazorUnit(ServiceUnit serviceUnit)
        {
            BlazorUnit blazorUnit = new BlazorUnit();
            blazorUnit.Id = serviceUnit.Id;
            blazorUnit.Name = serviceUnit.Name;

            return blazorUnit;
        }

        public static ServiceUnit MapBlazorServiceUnit(BlazorUnit blazorUnit)
        {
            ServiceUnit serviceUnit = new ServiceUnit();
            serviceUnit.Id = blazorUnit.Id;
            serviceUnit.Name = blazorUnit.Name;

            return serviceUnit;
        }
    }
}
