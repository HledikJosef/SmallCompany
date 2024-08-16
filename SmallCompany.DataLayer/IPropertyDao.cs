using SmallCompany.Models;

namespace SmallCompany.DataLayer
{
	public interface IPropertyDao
	{
		public Task<List<Property>> GetPropertiesFromDbAsync();

		public Task AddPropertyToDb(Property property);
	}
}
