using Microsoft.Extensions.DependencyInjection;
using SmallCompany.DataLayer;
using SmallCompany.DataLayer.Implementation;
using SmallCompany.ServiceLayer;
using SmallCompany.ServiceLayer.Impl;
using SmallCompany.ServiceLayer.Implementation;

namespace SmallCompany.CompositionRoot
{
    public static class ServiceCollectionExtensions
    {
        public static void AddServices(this IServiceCollection services, string connectionString)
        {

            //DataLayer
            services.AddSingleton<IConnectionStringProvider>(new ConnectionStringProvider(connectionString));
            services.AddTransient<IItemModelDao, ItemModelDao>();
            services.AddTransient<IItemTypeModelDao, ItemTypeModelDao>();
            services.AddTransient<IPropertyModelDao, PropertyModelDao>();
            services.AddTransient<IStockModelDao, StockModelDao>();
            services.AddTransient<IUnitModelDao, UnitModelDao>();
            services.AddTransient<IItemStockDao, ItemStockDao>();

            //ServiceLayer
            services.AddTransient<IPropertiesService, PropertiesService>();
            services.AddTransient<IItemModelService, ItemModelService>();
            services.AddTransient<IStockService, StockService>();
            services.AddTransient<IItemStockService, ItemStockService>();
        }
    }
}
