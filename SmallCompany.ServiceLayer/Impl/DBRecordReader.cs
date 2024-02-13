using System.Data;
using System.Data.SqlClient;

namespace SmallCompany.ServiceLayer.Impl
{
    public class DBRecordReader : IDBRecordReader
    {
        private readonly IConnectionStringProvider? connectionStringProvider;


        public DataSet ReadTable(string tableName)
        {
            DataSet dataSet = new DataSet();
            string sqlQuery = String.Format("SELECT * FROM {1}", tableName);
            using (SqlConnection connection = new SqlConnection(connectionStringProvider.ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                    {

                        dataAdapter.Fill(dataSet);
                    }
                }

            }
            return dataSet;
        }



    }
}

