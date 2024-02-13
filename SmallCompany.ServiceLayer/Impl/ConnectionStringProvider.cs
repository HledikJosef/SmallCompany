namespace SmallCompany.ServiceLayer.Impl
{
    public class ConnectionStringProvider : IConnectionStringProvider
    {
        public string ConnectionString { get; }

        public ConnectionStringProvider(string connectionString)
        {
            ConnectionString = connectionString;
        }

    }
}
