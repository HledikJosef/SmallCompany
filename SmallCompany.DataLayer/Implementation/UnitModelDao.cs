using Dapper;
using SmallCompany.Models;
using SmallCompany.Models.Data;
using System.Data.SqlClient;

namespace SmallCompany.DataLayer.Implementation
{
    public class UnitModelDao : IUnitModelDao
    {
        private readonly ApplicationDbContext context;
        private readonly IConnectionStringProvider connectionStringProvider;

        public UnitModelDao(IConnectionStringProvider connectionStringProvider, ApplicationDbContext context)
        {
            this.connectionStringProvider = connectionStringProvider;
            this.context = context;
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

        public List<UnitModel> ReadUnitsEF()
        {
            List<UnitModel> unitsFromSql = new List<UnitModel>(context.UnitModels);
            return unitsFromSql;
        }
    }
}
