using Dapper;
using DapperExtensions;
using SmallCompany.Models;
using SmallCompany.Models.Data;
using System.Data.SqlClient;

namespace SmallCompany.DataLayer.Implementation
{
    public class StockModelDao : IStockModelDao
    {
        private readonly ApplicationDbContext context;
        private readonly IConnectionStringProvider connectionStringProvider;

        public StockModelDao(IConnectionStringProvider connectionStringProvider, ApplicationDbContext context)
        {
            this.connectionStringProvider = connectionStringProvider;
            this.context = context;
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

        public List<StockModel> ReadStockModelsEF()
        {
            List<StockModel> stocksFromSql = new List<StockModel>(context.StockModels);
            return stocksFromSql;
        }

        public void WriteStockmodel(StockModel stockModel)
        {

            using (SqlConnection connection = new SqlConnection(connectionStringProvider.ConnectionString))
            {
                var rowsAffected = connection.Insert(stockModel);
            }
        }

        public void WriteStockModelEF(StockModel stockModel)
        {
            context.StockModels.Add(stockModel);
            var rowsAffected = context.SaveChanges();
        }
    }
}
