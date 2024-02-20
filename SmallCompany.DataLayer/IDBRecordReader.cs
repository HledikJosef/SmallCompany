using SmallCompany.DataLayer.Models;

namespace SmallCompany.DataLayer
{
    public interface IDBRecordReader
    {
        public List<PropertyModel> ReadProperties();
        public List<UnitModel> ReadUnits();
        public List<ItemTyp> ReadItemTyps();
        public List<StockModel> ReadStockModels();
    }
}
