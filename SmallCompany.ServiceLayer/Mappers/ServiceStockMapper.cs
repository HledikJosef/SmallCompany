using SmallCompany.Models;
using SmallCompany.ServiceLayer.ModelsService;

namespace SmallCompany.ServiceLayer.Mappers
{
    public static class ServiceStockMapper
    {
        public static ServiceStock MapServiceStockFromDao(Stock stock)
        {
            ServiceStock serviceStock = new ServiceStock();
            serviceStock.Id = stock.Id;
            serviceStock.Name = stock.Name;
            serviceStock.Location = stock.Location;
            serviceStock.Description = stock.Description;

            return serviceStock;
        }

        public static Stock MapServiceStockToDao(ServiceStock serviceStock)
        {
            Stock stock = new Stock();
            stock.Id = serviceStock.Id;
            stock.Name = serviceStock.Name;
            stock.Location = serviceStock.Location;
            stock.Description = serviceStock.Description;

            return stock;
        }
    }

}
