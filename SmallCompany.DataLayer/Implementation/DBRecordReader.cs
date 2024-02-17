﻿using Dapper;
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


        public List<PropertiesModel> ReadProperties()
        {
            string sqlCommand = "SELECT Id, PropertyName, PropertyType, PropertyDescription FROM PropertyList";
            List<PropertiesModel> propertiesFromSql = new List<PropertiesModel>();
            using (SqlConnection connection = new SqlConnection(connectionStringProvider.ConnectionString))
            {
                propertiesFromSql = connection.Query<PropertiesModel>(sqlCommand).ToList();
            }

            return propertiesFromSql;
        }
    }
}