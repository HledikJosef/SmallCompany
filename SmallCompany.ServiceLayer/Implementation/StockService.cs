using SmallCompany.DataLayer;
using SmallCompany.DataLayer.Models;
using SmallCompany.ServiceLayer.ModelsBlazor;

namespace SmallCompany.ServiceLayer.Implementation
{
    public class StockService : IStockService
    {
        private readonly IStockModelDao stockModelDao;

        public StockService(IStockModelDao stockModelDao)
        {
            this.stockModelDao = stockModelDao;
        }

        public bool CreateStockModel(StockBlazorModel blazorStock)
        {
            StockModel stockModel = MapStocks(blazorStock);
            bool isSuccessful = stockModelDao.WriteStockmodel(stockModel);

            return isSuccessful;
        }

        private StockModel MapStocks(StockBlazorModel blazorStock)
        {
            StockModel stockModel = new StockModel();
            stockModel.StockId = blazorStock.StockId;
            stockModel.StockTitel = blazorStock.StockTitel;
            stockModel.StockDescription = blazorStock.StockDescription;
            stockModel.StockLocation = blazorStock.StockLocation;
            stockModel.IsValid = blazorStock.IsValid;

            return stockModel;
        }
    }
}
