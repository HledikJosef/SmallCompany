using DapperExtensions;
using SmallCompany.DataLayer.Models;
using System.Data.SqlClient;

namespace SmallCompany.DataLayer.Implementation
{
    public class DBRecordWriter : IDBRecordWriter
    {
        private readonly IConnectionStringProvider connectionStringProvider;

        public DBRecordWriter(IConnectionStringProvider connectionStringProvider)
        {
            this.connectionStringProvider = connectionStringProvider;
        }

        public void WriteMaterialModel(MaterialModel materialModel)
        {
            using (SqlConnection connection = new SqlConnection(connectionStringProvider.ConnectionString))
            {
                try
                {
                    var rowsAffected = connection.Insert(materialModel);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            };
        }


    }
}
