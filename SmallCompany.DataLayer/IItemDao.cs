using SmallCompany.Models;

namespace SmallCompany.DataLayer
{
	public interface IItemDao
	{
		public Task<List<Item>> GetItemsFromSqlAsync();
		public Task AddItemWithPropertiesToDbAsync(Item itemWithProperties);
	}
}
