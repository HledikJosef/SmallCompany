using SmallCompany.ClientBlazorIdentity.ModelsBlazor;
using SmallCompany.Models;

namespace SmallCompany.ClientBlazorIdentity.Mappers
{
    public static class StockMapper
    {
        public static BlazorStock MapStock(Stock stock)
        {
            BlazorStock blazorStock = new BlazorStock();
            blazorStock.Id = stock.Id;
            blazorStock.Name = stock.Name;
            blazorStock.Location = stock.Location;
            blazorStock.Description = stock.Description;

            return blazorStock;
        }

        public static Stock MapStock(BlazorStock blazorStock)
        {
            Stock stock = new Stock();
            stock.Id = blazorStock.Id;
            stock.Name = blazorStock.Name;
            stock.Location = blazorStock.Location;
            stock.Description = blazorStock.Description;

            return stock;
        }
    }
}
