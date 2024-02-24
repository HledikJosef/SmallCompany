using Dapper;
using SmallCompany.DataLayer.Models;
using System.Data.SqlClient;

namespace SmallCompany.DataLayer.Implementation
{
    public class PropertyModelDao : IPropertyModelDao
    {
        private readonly IConnectionStringProvider connectionStringProvider;

        public PropertyModelDao(IConnectionStringProvider connectionStringProvider)
        {
            this.connectionStringProvider = connectionStringProvider;
        }

        public List<PropertyModel> ReadProperties()
        {
            string sqlCommand = "SELECT Id, PropertyName, PropertyType, PropertyDescription FROM PropertyModel";
            List<PropertyModel> propertiesFromSql = new List<PropertyModel>();
            using (SqlConnection connection = new SqlConnection(connectionStringProvider.ConnectionString))
            {
                propertiesFromSql = connection.Query<PropertyModel>(sqlCommand).ToList();
            }

            return propertiesFromSql;
        }
    }
}
