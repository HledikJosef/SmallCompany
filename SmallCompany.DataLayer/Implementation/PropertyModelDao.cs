using Dapper;
using SmallCompany.Models;
using SmallCompany.Models.Data;
using System.Data.SqlClient;

namespace SmallCompany.DataLayer.Implementation
{
    public class PropertyModelDao : IPropertyModelDao
    {
        private readonly IConnectionStringProvider connectionStringProvider;
        private readonly ApplicationDbContext context;

        public PropertyModelDao(IConnectionStringProvider connectionStringProvider, ApplicationDbContext context)
        {
            this.connectionStringProvider = connectionStringProvider;
            this.context = context;
        }

        public List<PropertyModel> ReadProperties()
        {
            string sqlCommand = "SELECT PropertyId, PropertyName, PropertyType, PropertyDescription FROM PropertyModel";
            List<PropertyModel> propertiesFromSql = new List<PropertyModel>();
            using (SqlConnection connection = new SqlConnection(connectionStringProvider.ConnectionString))
            {
                propertiesFromSql = connection.Query<PropertyModel>(sqlCommand).ToList();
            }

            return propertiesFromSql;
        }

        public List<PropertyModel> ReadPropertiesEF()
        {
            List<PropertyModel> propertiesFromSql = new List<PropertyModel>(context.PropertyModels.AsList());
            return propertiesFromSql;
        }
    }
}
