using SmallCompany.Models;

namespace SmallCompany.DataLayer
{
    public interface IStockModelDao
    {
        public List<StockModel> ReadStockModels();
        public void WriteStockmodel(StockModel stockmodel);
    }
}
