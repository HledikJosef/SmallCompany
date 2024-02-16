using Microsoft.Extensions.DependencyInjection;
using SmallCompany.DataLayer;
using SmallCompany.DataLayer.Implementation;
using SmallCompany.ServiceLayer;
using SmallCompany.ServiceLayer.Impl;

namespace SmallCompany.CompositionRoot
{
    public static class ServiceCollectionExtensions
    {
        public static void AddServices(this IServiceCollection services, string connectionString)
        {
            //DataLayer
            services.AddSingleton<IConnectionStringProvider>(new ConnectionStringProvider(connectionString));
            services.AddTransient<IDBRecordReader, DBRecordReader>();
            //ServiceLayer
            services.AddTransient<IPropertiesService, PropertiesService>();
            services.AddTransient<IMaterialModelCreator, MaterialModelCreator>();
        }
    }
}
