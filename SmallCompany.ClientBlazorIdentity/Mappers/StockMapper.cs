using SmallCompany.ClientBlazorIdentity.ModelsBlazor;
using SmallCompany.ServiceLayer.ModelsService;

namespace SmallCompany.ClientBlazorIdentity.Mappers
{
    public static class StockMapper
    {
        public static BlazorStock MappServiceBlazorStock(ServiceStock serviceStock)
        {
            BlazorStock blazorStock = new BlazorStock();
            blazorStock.Id = serviceStock.Id;
            blazorStock.Name = serviceStock.Name;
            blazorStock.Location = serviceStock.Location;
            blazorStock.Description = serviceStock.Description;

            return blazorStock;
        }

        public static ServiceStock MappBlazorServisStock(BlazorStock blazorStock)
        {
            ServiceStock serviceStock = new ServiceStock();
            serviceStock.Id = blazorStock.Id;
            serviceStock.Name = blazorStock.Name;
            serviceStock.Location = blazorStock.Location;
            serviceStock.Description = blazorStock.Description;

            return serviceStock;
        }
    }
}
