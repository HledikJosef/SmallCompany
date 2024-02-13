using SmallCompany.ClientBlazor.Data;
using SmallCompany.ServiceLayer;

namespace SmallCompany.ClientBlazor
{
    public class UI
    {
        private readonly IConnectionStringGetter connectionStringGetter;

        public UI(IConnectionStringGetter connectionStringGetter)
        {
            this.connectionStringGetter = connectionStringGetter;
        }

        public async Task StartAsync()
        {
            try
            {
                var builder = WebApplication.CreateBuilder();

                // Add services to the container.
                builder.Services.AddRazorPages();
                builder.Services.AddServerSideBlazor();
                builder.Services.AddSingleton<WeatherForecastService>();

                var app = builder.Build();

                // Configure the HTTP request pipeline.
                if (!app.Environment.IsDevelopment())
                {
                    app.UseExceptionHandler("/Error");
                    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                    app.UseHsts();
                }

                app.UseHttpsRedirection();

                app.UseStaticFiles();

                app.UseRouting();

                app.MapBlazorHub();
                app.MapFallbackToPage("/_Host");

                app.Run();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Něco se pokazilo. Podrobnosti níže:");
                Console.WriteLine($"{ex.Message}");
            }
        }

    }
}
