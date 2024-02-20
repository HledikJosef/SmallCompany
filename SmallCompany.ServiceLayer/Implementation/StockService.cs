using SmallCompany.DataLayer;
using SmallCompany.DataLayer.Models;
using SmallCompany.ServiceLayer.ModelsBlazor;

namespace SmallCompany.ServiceLayer.Implementation
{
    public class StockService : IStockService
    {
        private readonly IDBRecordWriter dBRecordWriter;

        public StockService(IDBRecordWriter dBRecordWriter)
        {
            this.dBRecordWriter = dBRecordWriter;
        }

        public bool CreateStockModel(StockBlazorModel blazorStock)
        {
            StockModel stockModel = MapStocks(blazorStock);
            bool isSuccessful = dBRecordWriter.WriteStockmodel(stockModel);

            return isSuccessful;
        }

        private StockModel MapStocks(StockBlazorModel blazorStock)
        {
            StockModel stockModel = new StockModel();
            stockModel.StockTitel = blazorStock.StockTitel;
            stockModel.StockDescription = blazorStock.StockDescription;
            stockModel.StockLocation = blazorStock.StockLocation;
            stockModel.IsValid = blazorStock.IsValid;

            return stockModel;
        }
    }
}
