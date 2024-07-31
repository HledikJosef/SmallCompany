using Dapper;
using SmallCompany.Models;
using System.Data.SqlClient;

namespace SmallCompany.DataLayer.Implementation
{
    public class ItemTypModelDao : IItemTypModelDao
    {
        private readonly IConnectionStringProvider connectionStringProvider;

        public ItemTypModelDao(IConnectionStringProvider connectionStringProvider)
        {
            this.connectionStringProvider = connectionStringProvider;
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
    }
}
