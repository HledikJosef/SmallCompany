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
            string sqlCommand = "SELECT ItemUnit FROM UnitModel";
            List<UnitModel> unitsFromSql = new List<UnitModel>();
            using (SqlConnection connection = new SqlConnection(connectionStringProvider.ConnectionString))
            {
                unitsFromSql = connection.Query<UnitModel>(sqlCommand).ToList();
            }

            return unitsFromSql;
        }

        public List<ItemTyp> ReadItemTyps()
        {
            string sqlCommand = "SELECT ItemTyp FROM ItemTypModel";
            List<ItemTyp> itemTypsFromSql = new List<ItemTyp>();
            using (SqlConnection connection = new SqlConnection(connectionStringProvider.ConnectionString))
            {
                itemTypsFromSql = connection.Query<ItemTyp>(sqlCommand).ToList();
            }

            return itemTypsFromSql;
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
    }
}
