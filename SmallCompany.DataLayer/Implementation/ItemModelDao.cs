using Dapper;
using DapperExtensions;
using SmallCompany.Models;
using SmallCompany.Models.Data;
using System.Data.SqlClient;

namespace SmallCompany.DataLayer.Implementation
{
    public class ItemModelDao : IItemModelDao
    {
        private readonly ApplicationDbContext context;
        private readonly IConnectionStringProvider connectionStringProvider;

        public ItemModelDao(IConnectionStringProvider connectionStringProvider, ApplicationDbContext context)
        {
            this.connectionStringProvider = connectionStringProvider;
            this.context = context;
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

        public List<ItemModel> ReadItemModelsEF()
        {
            List<ItemModel> itemModelsFromSql = new(context.ItemModels.AsList());
            return itemModelsFromSql;
        }


        public void WriteItemModel(ItemModel itemModel)
        {
            using (SqlConnection connection = new SqlConnection(connectionStringProvider.ConnectionString))
            {
                var rowsAffected = connection.Insert(itemModel);
            };
        }

        public void WriteItemModelEF(ItemModel itemModel)
        {
            context.ItemModels.Add(itemModel);
            context.SaveChanges();
        }
    }
}
