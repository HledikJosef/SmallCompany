using Dapper;
using SmallCompany.Models;
using SmallCompany.Models.Data;
using System.Data.SqlClient;

namespace SmallCompany.DataLayer.Implementation
{
    public class ItemTypeModelDao : IItemTypeModelDao
    {
        private readonly ApplicationDbContext context;
        private readonly IConnectionStringProvider connectionStringProvider;

        public ItemTypeModelDao(IConnectionStringProvider connectionStringProvider, ApplicationDbContext context)
        {
            this.connectionStringProvider = connectionStringProvider;
            this.context = context;
        }

        public List<ItemType> ReadItemTypes()
        {
            string sqlCommand = "SELECT ItemTypeId, ItemTyp FROM ItemTypModel";
            List<ItemType> itemTypesFromSql = new List<ItemType>();
            using (SqlConnection connection = new SqlConnection(connectionStringProvider.ConnectionString))
            {
                itemTypesFromSql = connection.Query<ItemType>(sqlCommand).ToList();
            }

            return itemTypesFromSql;
        }

        public List<ItemType> ReadItemTypesEF()
        {
            List<ItemType> itemTypesFromSql = new List<ItemType>(context.ItemTypes);
            return itemTypesFromSql;
        }
    }
}
