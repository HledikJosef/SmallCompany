using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace SmallCompany.Models.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<DateType> DateTypes { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<ItemPropertyValue> ItemsPropertyValue { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<TypeOfItem> TypesOfItems { get; set; }
        public DbSet<Unit> Units { get; set; }

    }
}
