using SmallCompany.DataLayer.Models;

namespace SmallCompany.DataLayer
{
    public interface IItemStockDao
    {
        public List<ItemOnStock> ReadItemsOnStock(string itemModel);
        public void WriteItemOnStock(ItemOnStock item);
    }
}
