using SmallCompany.Models;
using SmallCompany.Models.Data;

namespace SmallCompany.DataLayer.Implementation
{
    public class ItemDao : IItemDao
    {
        private readonly ApplicationDbContext context;

        public ItemDao(ApplicationDbContext context)
        {
            this.context = context;
        }

        public List<Item> GetItemsFromSql()
        {
            List<Item> itemsFromSql = new List<Item>();
            itemsFromSql = context.Items.ToList();

            return itemsFromSql;
        }

        public void AddItemToSql(Item item)
        {
            context.Items.Add(item);
        }
    }
}
