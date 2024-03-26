using SmallCompany.ServiceLayer.ModelsBlazor;

namespace SmallCompany.ServiceLayer
{
    public interface IStockService
    {
        public void CreateStockModel(StockBlazorModel blazorStock);
        public List<StockBlazorModel> GetBlazorStockList();
    }
}
