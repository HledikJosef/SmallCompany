using Microsoft.EntityFrameworkCore;
using SmallCompany.Models;
using SmallCompany.Models.Data;

namespace SmallCompany.DataLayer.Implementation
{
	public class PropertyDao : IPropertyDao
	{
		private readonly ApplicationDbContext context;

		public PropertyDao(ApplicationDbContext context)
		{
			this.context = context;
		}

		public async Task<List<Property>> GetPropertiesFromDbAsync()
		{
			List<Property> propertiesFromDb = new List<Property>();
			propertiesFromDb = await context.Properties.ToListAsync();

			return propertiesFromDb;
		}

		public async Task AddPropertyToDb(Property property)
		{
			await context.Properties.AddAsync(property);
			await context.SaveChangesAsync();
		}
	}
}
