using Microsoft.Extensions.DependencyInjection;
using SmallCompany.DataLayer;
using SmallCompany.DataLayer.Implementation;

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

            //ServiceLayer

        }
    }
}
