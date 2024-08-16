using Microsoft.Extensions.DependencyInjection;
using SmallCompany.DataLayer;
using SmallCompany.DataLayer.Implementation;
using SmallCompany.ServiceLayer;
using SmallCompany.ServiceLayer.Implementation;

namespace SmallCompany.CompositionRoot
{
	public static class ServiceCollectionExtensions
	{
		public static void AddServices(this IServiceCollection services, string connectionString)
		{

			//DataLayer
			services.AddTransient<IDateTypeDao, DateTypeDao>();
			services.AddTransient<IItemDao, ItemDao>();
			services.AddTransient<IPropertyDao, PropertyDao>();
			services.AddTransient<ITypeOfItemDao, TypeOfItemDao>();
			services.AddTransient<IUnitReaderDao, UnitDao>(); //rozděleno na metodu pouze ke čtení a k zápisu
			services.AddTransient<IUnitWriterDao, UnitDao>();
			services.AddTransient<IStockReaderDao, StockDao>();
			services.AddTransient<IStockWriterDao, StockDao>();

			//ServiceLayer
			services.AddTransient<IUnitService, UnitService>();
			services.AddTransient<IStockService, StockService>();
			services.AddTransient<ITypeOfItemService, TypeOfItemService>();
			services.AddTransient<IDateTypeService, DateTypeService>();
			services.AddTransient<IPropertyService, PropertyService>();

		}
	}
}
