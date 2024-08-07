using SmallCompany.Models;

namespace SmallCompany.DataLayer
{
    public interface IItemDao
    {
        public List<Item> GetItemsFromSql();
        public void AddItemToSql(Item item);
    }
}
