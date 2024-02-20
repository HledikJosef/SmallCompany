using SmallCompany.ServiceLayer.ModelsBlazor;

namespace SmallCompany.ServiceLayer
{
    public interface IStockService
    {
        public bool CreateStockModel(StockBlazorModel blazorStock);
    }
}
