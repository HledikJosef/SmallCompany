using Microsoft.EntityFrameworkCore;
using SmallCompany.Models;
using SmallCompany.Models.Data;

namespace SmallCompany.DataLayer.Implementation
{
    public class ItemDao : IItemDao
    {
        private readonly ApplicationDbContext context;
        private readonly string connectionString;
        public ItemDao(ApplicationDbContext context)
        {
            this.context = context;
            connectionString = context.Database.GetDbConnection().ConnectionString;
        }

        public async Task<List<Item>> GetItemsFromSqlAsync()
        {
            List<Item> itemsFromSql = new List<Item>();
            itemsFromSql = await context.Items.ToListAsync();

            return itemsFromSql;
        }

        public async Task AddItemWithPropertiesToDbAsync(Item itemWithProperties)
        {
            List<Item> existingItems = await CheckExistingItemAsync(itemWithProperties);

            if (existingItems.Count() == 0)
            {
                await context.Items.AddAsync(itemWithProperties);
                await context.SaveChangesAsync();
            }
        }

        private async Task<List<Item>> CheckExistingItemAsync(Item item)
        {
            List<Item> existingItems = new List<Item>();

            string sqlQuery = $"SELECT i.* FROM Items i WHERE i.Name = '{item.Name}' AND i.Id IN ( SELECT ipv1.ItemId FROM ItemsPropertyValue ipv1 WHERE ";

            int index = 0;

            string whereClause = "";

            foreach (var ipv in item.ItemPropertyValues)
            {
                if (!string.IsNullOrEmpty(whereClause))
                {
                    whereClause += "OR ";
                }

                whereClause += $"(ipv1.PropertyId = {ipv.PropertyId} AND ipv1.Value = '{ipv.Value}' ) ";

                index++;

            }

            sqlQuery += whereClause;

            sqlQuery += $"GROUP BY ipv1.ItemId HAVING COUNT(DISTINCT ipv1.PropertyId) = {index} )";


            existingItems = context.Items.FromSqlRaw(sqlQuery).ToList();

            return existingItems;
        }



    }
}

