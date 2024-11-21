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
            itemsFromSql = await context.Items.Include(i => i.ItemPropertyValues).ThenInclude(ipv => ipv.Property).ToListAsync();

            return itemsFromSql;
        }

        public async Task AddItemWithPropertiesToDbAsync(Item itemWithProperties)
        {
            await context.Items.AddAsync(itemWithProperties);
            await context.SaveChangesAsync();

        }

        public async Task<List<int>> CheckExistingItemAsync(Item item)
        {
            List<Item> existingItems = new List<Item>();

            List<int> existingId = new List<int>();

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


            existingItems = await context.Items.FromSqlRaw(sqlQuery).ToListAsync();

            existingId = existingItems.Select(i => i.Id).ToList();

            return existingId;
        }



    }
}

