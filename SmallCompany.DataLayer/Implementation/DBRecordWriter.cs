namespace SmallCompany.DataLayer.Implementation
{
    public class DBRecordWriter
    {
        private readonly IConnectionStringProvider connectionStringProvider;

        public DBRecordWriter(IConnectionStringProvider connectionStringProvider)
        {
            this.connectionStringProvider = connectionStringProvider;
        }

        public void WriteMaterialModel()
        {

        }

    }
}
