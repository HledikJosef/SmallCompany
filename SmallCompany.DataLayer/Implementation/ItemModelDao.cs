using Dapper;
using DapperExtensions;
using SmallCompany.DataLayer.Models;
using System.Data.SqlClient;

namespace SmallCompany.DataLayer.Implementation
{
    public class ItemModelDao : IItemModelDao
    {
        private readonly IConnectionStringProvider connectionStringProvider;

        public ItemModelDao(IConnectionStringProvider connectionStringProvider)
        {
            this.connectionStringProvider = connectionStringProvider;
        }

        public List<ItemModel> ReadItemModels()
        {
            string sqlCommand = "SELECT ItemId, ItemGroupName, ItemDescription, ItemColor, ItemHardness, ItemDensity, ItemDiameter, ItemWidth, ItemLength, ItemHigh, " +
                "ItemThickness, ItemWeight, ItemUnit, IsValid FROM ItemModel";
            List<ItemModel> itemModelsFromSql = new List<ItemModel>();
            using (SqlConnection connection = new SqlConnection(connectionStringProvider.ConnectionString))
            {
                itemModelsFromSql = connection.Query<ItemModel>(sqlCommand).ToList();
            };

            return itemModelsFromSql;
        }

        public void WriteItemModel(ItemModel itemModel)
        {
            using (SqlConnection connection = new SqlConnection(connectionStringProvider.ConnectionString))
            {
                var rowsAffected = connection.Insert(itemModel);
            };
        }
    }
}
