using SmallCompany.ClientBlazorIdentity.ModelsBlazor;
using SmallCompany.ServiceLayer.ModelsService;

namespace SmallCompany.ClientBlazorIdentity.Mappers
{
    public static class TypeOfItemMapper
    {
        public static BlazorTypeOfItem MapServiceBlazorTypeOfItem(ServiceTypeOfItem serviceTypeOfItem)
        {
            BlazorTypeOfItem blazorTypeOfItem = new BlazorTypeOfItem();

            blazorTypeOfItem.Id = serviceTypeOfItem.Id;
            blazorTypeOfItem.Name = serviceTypeOfItem.Name;

            return blazorTypeOfItem;
        }

        public static ServiceTypeOfItem MapBlazorServiceTypeOfItem(BlazorTypeOfItem blazorTypeOfItem)
        {
            ServiceTypeOfItem serviceTypeOfItem = new ServiceTypeOfItem();

            serviceTypeOfItem.Id = blazorTypeOfItem.Id;
            serviceTypeOfItem.Name = blazorTypeOfItem.Name;

            return serviceTypeOfItem;
        }
    }
}
