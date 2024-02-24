using SmallCompany.DataLayer.Models;

namespace SmallCompany.DataLayer
{
    public interface IStockModelDao
    {
        public List<StockModel> ReadStockModels();
        public bool WriteStockmodel(StockModel stockmodel);
    }
}
