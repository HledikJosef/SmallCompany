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

        public List<ItemModel> ReadItemsOnStock()
        {
            string sqlCommand = "SELECT ItemId, ItemGroupName, ItemDescription, ItemColor, ItemHardness, ItemDensity, ItemDiameter, ItemWidth, ItemLength, ItemHigh, " +
                "ItemThickness, ItemWeight, ItemUnit, IsValid FROM ItemModel";
            List<ItemModel> itemsOnStockFromSql = new List<ItemModel>();
            using (SqlConnection connection = new SqlConnection(connectionStringProvider.ConnectionString))
            {
                itemsOnStockFromSql = connection.Query<ItemModel>(sqlCommand).ToList();
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
