using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
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

                string? connectionString = builder.Configuration.GetConnectionString("SmallCompanyDb")
                        ?? throw new InvalidOperationException();
                builder.Services.AddServices(connectionString);

                builder.Services.AddDbContext<AplicationDBContext>(options => options.UseSqlServer(connectionString));
                builder.Services.AddDatabaseDeveloperPageExceptionFilter();
                builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<AplicationDBContext>();

                builder.Services.Configure<IdentityOptions>(options =>
                {
                    //Password settings
                    options.Password.RequireDigit = true;
                    options.Password.RequireUppercase = true;
                    options.Password.RequireLowercase = true;
                    options.Password.RequireNonAlphanumeric = false;
                    options.Password.RequiredLength = 6;
                    options.Password.RequiredUniqueChars = 0;

                    //Lockout settings
                    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                    options.Lockout.MaxFailedAccessAttempts = 5;
                    options.Lockout.AllowedForNewUsers = true;

                    //User settings
                    options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
                    options.User.RequireUniqueEmail = true;
                });

                builder.Services.ConfigureApplicationCookie(options =>
                {
                    //Cookie settings
                    options.Cookie.HttpOnly = true;
                    options.ExpireTimeSpan = TimeSpan.FromMinutes(5);
                    options.LoginPath = "/Identity/Account/Login";
                    options.AccessDeniedPath = "/Identity/Account/AccessDenied";
                    options.SlidingExpiration = true;
                });

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

                app.UseAuthorization();
                app.UseAuthentication();

                app.MapBlazorHub();
                app.MapFallbackToPage("/_Host");

                await Task.Run(app.Run);

            }
            catch (Exception ex)
            {
                Console.WriteLine("N�co se pokazilo. Podrobnosti n�e:");
                Console.WriteLine($"{ex.Message}");
            }
        }



    }
}
