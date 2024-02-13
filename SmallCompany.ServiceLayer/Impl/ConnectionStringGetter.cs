namespace SmallCompany.ServiceLayer.Impl
{
    public class ConnectionStringGetter : IConnectionStringGetter
    {
        public ConnectionStringGetter(string connectionString)
        {
            ConnectionString = connectionString;
        }
        public string ConnectionString { get; }

        //public void GetConnectionString()
        //{
        //    SqlConnectionStringBuilder csBuilder = new SqlConnectionStringBuilder();
        //    csBuilder.DataSource = @"localhost\SQLEXPRESS";
        //    csBuilder.InitialCatalog = "SmallCompanyDB";
        //    csBuilder.IntegratedSecurity = true;
        //    ConnectionString = csBuilder.ConnectionString;
        //}


    }
}
