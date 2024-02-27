using SmallCompany.DataLayer.Models;

namespace SmallCompany.DataLayer
{
    public interface IItemStockDao
    {
        public List<ItemModel> ReadItemsOnStock();
        public bool WriteItemOnStock(ItemOnStock item);
    }
}
