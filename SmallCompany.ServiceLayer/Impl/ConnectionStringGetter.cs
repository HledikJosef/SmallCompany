﻿using System.Data.SqlClient;

namespace SmallCompany.ServiceLayer.Impl
{
    public class ConnectionStringGetter : IConnectionStringGetter
    {
        public string ConnectionString { get; set; }

        public void GetConnectionString()
        {
            SqlConnectionStringBuilder csBuilder = new SqlConnectionStringBuilder();
            csBuilder.DataSource = @"localhost\SQLEXPRESS";
            csBuilder.InitialCatalog = "SmallCompanyDB";
            csBuilder.IntegratedSecurity = true;
            ConnectionString = csBuilder.ConnectionString;
        }


    }
}
