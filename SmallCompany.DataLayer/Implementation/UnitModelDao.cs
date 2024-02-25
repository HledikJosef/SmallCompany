using Dapper;
using SmallCompany.DataLayer.Models;
using System.Data.SqlClient;

namespace SmallCompany.DataLayer.Implementation
{
    public class UnitModelDao : IUnitModelDao
    {
        private readonly IConnectionStringProvider connectionStringProvider;

        public UnitModelDao(IConnectionStringProvider connectionStringProvider)
        {
            this.connectionStringProvider = connectionStringProvider;
        }

        public List<UnitModel> ReadUnits()
        {
            string sqlCommand = "SELECT UnitId, ItemUnit FROM UnitModel";
            List<UnitModel> unitsFromSql = new List<UnitModel>();
            using (SqlConnection connection = new SqlConnection(connectionStringProvider.ConnectionString))
            {
                unitsFromSql = connection.Query<UnitModel>(sqlCommand).ToList();
            }

            return unitsFromSql;
        }
    }
}
