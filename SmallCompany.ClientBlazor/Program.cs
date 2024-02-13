using SmallCompany.CompositionRoot;

namespace SmallCompany.ClientBlazor
{
    public class Program
    {
        private static async Task Main(string[] args)
        {
            IServiceCollection services = new ServiceCollection();
            services.AddSmallCompanyServices();
            services.AddTransient<UI>();

            ServiceProvider serviceProvider = services.BuildServiceProvider();

            UI uI = serviceProvider.GetRequiredService<UI>();
            await uI.StartAsync();
        }
    }
}
