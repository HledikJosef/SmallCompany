using SmallCompany.ServiceLayer.ModelsBlazor;

namespace SmallCompany.ServiceLayer
{
    public interface IItemStockService
    {
        public bool CreateItemStockRecord(ItemStockRecordBlazorModel item);
        public List<ItemStockRecordBlazorModel> CreateItemsOnStockOutput(int stockId);
    }
}
