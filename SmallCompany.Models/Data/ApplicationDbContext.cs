using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace SmallCompany.Models.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<ItemModel> ItemModels { get; set; }
        public DbSet<ItemOnStock> ItemsOnStocks { get; set; }
        public DbSet<ItemType> ItemTypes { get; set; }
        public DbSet<PropertyModel> PropertyModels { get; set; }
        public DbSet<StockModel> StockModels { get; set; }
        public DbSet<UnitModel> UnitModels { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(connectionString);
        //}
    }
}
