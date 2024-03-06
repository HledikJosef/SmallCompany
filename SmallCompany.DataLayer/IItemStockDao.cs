using SmallCompany.DataLayer.Models;

namespace SmallCompany.DataLayer
{
    public interface IItemStockDao
    {
        public List<ItemOnStock> ReadItemsOnStock(int stockId);
        public bool WriteItemOnStock(ItemOnStock item);
    }
}
