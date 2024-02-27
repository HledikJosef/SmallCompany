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
            StockModel stockModel = MapStocksModel(blazorStock);
            bool isSuccessful = stockModelDao.WriteStockmodel(stockModel);

            return isSuccessful;
        }

        private StockModel MapStocksModel(StockBlazorModel blazorStock)
        {
            StockModel stockModel = new StockModel();
            stockModel.StockId = blazorStock.StockId;
            stockModel.StockTitel = blazorStock.StockTitel;
            stockModel.StockDescription = blazorStock.StockDescription;
            stockModel.StockLocation = blazorStock.StockLocation;
            stockModel.IsValid = blazorStock.IsValid;

            return stockModel;
        }

        public List<StockBlazorModel> GetBlazorStockList()
        {
            List<StockModel> stocksFromSql = stockModelDao.ReadStockModels();
            List<StockBlazorModel> blazorStockList = stocksFromSql.Select(stock => MapStocksFromSql(stock)).ToList();


            return blazorStockList;
        }

        private StockBlazorModel MapStocksFromSql(StockModel stockFromSql)
        {
            StockBlazorModel blazorStock = new StockBlazorModel();
            blazorStock.StockId = stockFromSql.StockId;
            blazorStock.StockTitel = stockFromSql.StockTitel;
            blazorStock.StockDescription = stockFromSql.StockDescription;
            blazorStock.StockLocation = stockFromSql.StockLocation;
            blazorStock.IsValid = stockFromSql.IsValid;

            return blazorStock;

        }

    }
}
