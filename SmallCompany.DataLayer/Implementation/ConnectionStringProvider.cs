namespace SmallCompany.DataLayer.Implementation
{
    public class ConnectionStringProvider : IConnectionStringProvider
    {
        public string ConnectionString { get; set; }

        public ConnectionStringProvider(string connectionString)
        {
            ConnectionString = connectionString;
        }

    }
}
