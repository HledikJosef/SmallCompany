using SmallCompany.DataLayer.Models;

namespace SmallCompany.DataLayer
{
    public interface IDBRecordReader
    {
        public List<PropertiesModel> ReadProperties();
    }
}
