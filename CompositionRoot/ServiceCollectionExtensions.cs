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
            services.AddTransient<IUnitDao, UnitDao>();

            //ServiceLayer
            services.AddTransient<IUnitService, UnitService>();

        }
    }
}
