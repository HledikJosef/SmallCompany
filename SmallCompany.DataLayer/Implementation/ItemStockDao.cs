using Dapper;
using DapperExtensions;
using SmallCompany.Models;
using SmallCompany.Models.Data;
using System.Data.SqlClient;

namespace SmallCompany.DataLayer.Implementation
{
    public class ItemStockDao : IItemStockDao
    {
        private readonly ApplicationDbContext context;
        private readonly IConnectionStringProvider connectionStringProvider;

        public ItemStockDao(IConnectionStringProvider connectionStringProvider, ApplicationDbContext context)
        {
            this.connectionStringProvider = connectionStringProvider;
            this.context = context;
        }

        public List<ItemOnStock> ReadItemsOnStock(string itemModel)
        {
            string sqlCommand = string.Format("SELECT ItemId, ItemGroupName, ItemDescription, ItemType, ItemColor, ItemHardness, ItemDensity, ItemDiameter, ItemWidth, ItemLength, ItemHigh, " +
                "ItemThickness, ItemWeight, ItemQuantity, ItemUnit, StockId FROM ItemOnStock WHERE ItemGroupName='{0}'", itemModel);
            List<ItemOnStock> itemsOnStockFromSql = new List<ItemOnStock>();
            using (SqlConnection connection = new SqlConnection(connectionStringProvider.ConnectionString))
            {
                itemsOnStockFromSql = connection.Query<ItemOnStock>(sqlCommand).ToList();
            }

            return itemsOnStockFromSql;
        }

        public List<ItemOnStock> ReadItemsOnStockEF(string itemModel)
        {
            List<ItemOnStock> itemsOnStockFromSql = new List<ItemOnStock>(context.ItemsOnStocks.Where(itemOnStock => itemOnStock.ItemGroupName == itemModel));
            return itemsOnStockFromSql;
        }

        public void WriteItemOnStock(ItemOnStock item)
        {
            using (SqlConnection connection = new SqlConnection(connectionStringProvider.ConnectionString))
            {
                var rowsAffected = connection.Insert(item);
            };
        }

        public void WriteItemOnStockEF(ItemOnStock item)
        {
            context.ItemsOnStocks.Add(item);
            context.SaveChanges();
        }
    }
}
