using SmallCompany.Models;
using SmallCompany.ServiceLayer.ModelsService;

namespace SmallCompany.ServiceLayer
{
	public interface IItemService
	{
		public Task<List<Item>> GetItemsFromDao();
		public Task AddItemWithProperties(ServiceItem serviceItem);
	}
}
