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

        public void CreateStockModel(StockBlazorModel blazorStock)
        {
            StockModel stockModel = MapStocksModel(blazorStock);
            stockModelDao.WriteStockmodel(stockModel);
        }

        private StockModel MapStocksModel(StockBlazorModel blazorStock)
        {
            StockModel stockModel = new StockModel();
            stockModel.StockId = blazorStock.StockId;
            stockModel.StockTitel = blazorStock?.StockTitle ?? throw new InvalidOperationException();
            stockModel.StockDescription = blazorStock?.StockDescription ?? throw new InvalidOperationException();
            stockModel.StockLocation = blazorStock?.StockLocation ?? throw new InvalidOperationException();
            stockModel.IsValid = true; /*blazorStock.IsValid();*/

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
            blazorStock.StockTitle = stockFromSql.StockTitel;
            blazorStock.StockDescription = stockFromSql.StockDescription;
            blazorStock.StockLocation = stockFromSql.StockLocation;
            //blazorStock.IsValid = stockFromSql.IsValid();

            return blazorStock;

        }

    }
}
