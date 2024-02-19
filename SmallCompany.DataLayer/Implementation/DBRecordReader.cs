using Dapper;
using SmallCompany.DataLayer.Models;
using System.Data.SqlClient;

namespace SmallCompany.DataLayer.Implementation
{
    public class DBRecordReader : IDBRecordReader
    {
        private readonly IConnectionStringProvider connectionStringProvider;

        public DBRecordReader(IConnectionStringProvider connectionStringProvider)
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

        public List<UnitModel> ReadUnits()
        {
            string sqlCommand = "SELECT Unit FROM UnitModel";
            List<UnitModel> unitsFromSql = new List<UnitModel>();
            using (SqlConnection connection = new SqlConnection(connectionStringProvider.ConnectionString))
            {
                unitsFromSql = connection.Query<UnitModel>(sqlCommand).ToList();
            }

            return unitsFromSql;
        }
    }
}
