using Dapper;
using DapperExtensions;
using SmallCompany.DataLayer.Models;
using System.Data.SqlClient;

namespace SmallCompany.DataLayer.Implementation
{
    public class ItemStockDao : IItemStockDao
    {
        private readonly IConnectionStringProvider connectionStringProvider;

        public ItemStockDao(IConnectionStringProvider connectionStringProvider)
        {
            this.connectionStringProvider = connectionStringProvider;
        }

        public List<ItemOnStock> ReadItemsOnStock(int stockId)
        {
            string sqlCommand = string.Format("SELECT ItemId, ItemGroupName, ItemDescription, ItemType, ItemColor, ItemHardness, ItemDensity, ItemDiameter, ItemWidth, ItemLength, ItemHigh, " +
                "ItemThickness, ItemWeight, ItemQuantity, ItemUnit, StockId FROM ItemOnStock WHERE StockId={0}", stockId);
            List<ItemOnStock> itemsOnStockFromSql = new List<ItemOnStock>();
            using (SqlConnection connection = new SqlConnection(connectionStringProvider.ConnectionString))
            {
                itemsOnStockFromSql = connection.Query<ItemOnStock>(sqlCommand).ToList();
            }

            return itemsOnStockFromSql;
        }

        public bool WriteItemOnStock(ItemOnStock item)
        {
            using (SqlConnection connection = new SqlConnection(connectionStringProvider.ConnectionString))
            {
                try
                {
                    var rowsAffected = connection.Insert(item);
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    return false;
                }
            };
        }
    }
}
