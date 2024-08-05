using SmallCompany.Models;

namespace SmallCompany.DataLayer
{
    public interface IItemStockDao
    {
        public List<ItemOnStock> ReadItemsOnStock(string itemModel);
        public List<ItemOnStock> ReadItemsOnStockEF(string itemModel);

        public void WriteItemOnStock(ItemOnStock item);
        public void WriteItemOnStockEF(ItemOnStock item);
    }
}
