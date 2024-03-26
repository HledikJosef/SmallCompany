using Dapper;
using DapperExtensions;
using SmallCompany.DataLayer.Models;
using System.Data.SqlClient;

namespace SmallCompany.DataLayer.Implementation
{
    public class StockModelDao : IStockModelDao
    {
        private readonly IConnectionStringProvider connectionStringProvider;

        public StockModelDao(IConnectionStringProvider connectionStringProvider)
        {
            this.connectionStringProvider = connectionStringProvider;
        }

        public List<StockModel> ReadStockModels()
        {
            string sqlComman = "SELECT StockId, StockTitel, StockDescription, StockLocation, IsValid FROM StockModel";
            List<StockModel> stocksFromSql = new List<StockModel>();
            using (SqlConnection connection = new SqlConnection(connectionStringProvider.ConnectionString))
            {
                stocksFromSql = connection.Query<StockModel>(sqlComman).ToList();
            }

            return stocksFromSql;
        }

        public void WriteStockmodel(StockModel stockmodel)
        {
            using (SqlConnection connection = new SqlConnection(connectionStringProvider.ConnectionString))
            {
                var rowsAffected = connection.Insert(stockmodel);
            }
        }
    }
}
