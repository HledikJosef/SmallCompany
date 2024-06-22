using Dapper;
using SmallCompany.DataLayer.Models;
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

        public List<ItemTyp> ReadItemTypes()
        {
            string sqlCommand = "SELECT ItemTypId, ItemTyp FROM ItemTypModel";
            List<ItemTyp> itemTypesFromSql = new List<ItemTyp>();
            using (SqlConnection connection = new SqlConnection(connectionStringProvider.ConnectionString))
            {
                itemTypesFromSql = connection.Query<ItemTyp>(sqlCommand).ToList();
            }

            return itemTypesFromSql;
        }
    }
}
