using SmallCompany.ServiceLayer.ModelsBlazor;

namespace SmallCompany.ServiceLayer
{
    public interface IItemStockService
    {
        public void CreateItemStockRecord(ItemStockRecordBlazorModel item);
        public List<ItemStockRecordBlazorModel> CreateItemsOnStockOutput(string itemModel);
    }
}
