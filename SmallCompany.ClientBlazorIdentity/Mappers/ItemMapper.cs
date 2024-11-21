using SmallCompany.ClientBlazorIdentity.ModelsBlazor;
using SmallCompany.ServiceLayer.ModelsService;

namespace SmallCompany.ClientBlazorIdentity.Mappers
{
    public static class ItemMapper
    {
        public static ServiceItem MapBlazorServiceItem(BlazorItem blazorItem)
        {
            ServiceItem serviceItem = new ServiceItem();

            serviceItem.Id = blazorItem.Id;
            serviceItem.Name = blazorItem.Name;
            serviceItem.UnitId = blazorItem.UnitId;
            serviceItem.TypeOfItemId = blazorItem.TypeOfItemId;

            return serviceItem;
        }

        public static BlazorItem MapServiceBlazorItem(ServiceItem serviceItem)
        {
            BlazorItem blazorItem = new BlazorItem();

            blazorItem.Id = serviceItem.Id;
            blazorItem.Name = serviceItem.Name;
            blazorItem.UnitId = serviceItem.UnitId;
            blazorItem.TypeOfItemId = serviceItem.TypeOfItemId;

            return blazorItem;
        }
    }
}
