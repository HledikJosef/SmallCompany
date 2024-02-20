using SmallCompany.DataLayer.Models;

namespace SmallCompany.DataLayer
{
    public interface IDBRecordWriter
    {
        public bool WriteItemModel(ItemModel itemModel);
        public bool WriteStockmodel(StockModel stockmodel);
    }
}
