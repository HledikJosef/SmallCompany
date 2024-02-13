using System.Data;

namespace SmallCompany.ServiceLayer
{
    public interface IDBRecordReader
    {
        public DataSet ReadTable(string tableName);
    }
}
