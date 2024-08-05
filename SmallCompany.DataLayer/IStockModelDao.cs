using SmallCompany.Models;

namespace SmallCompany.DataLayer
{
    public interface IStockModelDao
    {
        public List<StockModel> ReadStockModels();
        public List<StockModel> ReadStockModelsEF();
        public void WriteStockmodel(StockModel stockmodel);

        public void WriteStockModelEF(StockModel stockModel);
    }
}
