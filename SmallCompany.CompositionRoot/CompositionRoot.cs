using Microsoft.Extensions.DependencyInjection;
using SmallCompany.ServiceLayer;
using SmallCompany.ServiceLayer.Impl;

namespace SmallCompany.CompositionRoot
{
    public static class CompositionRoot
    {
        public static IServiceCollection AddSmallCompanyServices(this IServiceCollection services)
        {
            //ServiceLayer
            services.AddTransient<IConnectionStringGetter, ConnectionStringGetter>();

            return services;

        }

    }
}
