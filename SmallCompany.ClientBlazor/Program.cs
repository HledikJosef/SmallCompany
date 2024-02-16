using SmallCompany.ClientBlazor.Data;
using SmallCompany.CompositionRoot;

namespace SmallCompany.ClientBlazor
{
    public class Program
    {
        private static async Task Main(string[] args)
        {
            try
            {


                var builder = WebApplication.CreateBuilder();

                // Add services to the container.
                builder.Services.AddRazorPages();
                builder.Services.AddServerSideBlazor();
                builder.Services.AddSingleton<WeatherForecastService>();

                string? connectionString = builder.Configuration.GetConnectionString("SmallCompanyDb")
                        ?? throw new InvalidOperationException();
                builder.Services.AddServices(connectionString);

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
                Console.WriteLine("Nìco se pokazilo. Podrobnosti níže:");
                Console.WriteLine($"{ex.Message}");
            }
        }



    }
}
