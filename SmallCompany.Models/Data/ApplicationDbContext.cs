using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace SmallCompany.Models.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Address> Addresses { get; set; }
        public DbSet<ContactPerson> ContactPersons { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<DateType> DateTypes { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<ItemPropertyValue> ItemsPropertyValue { get; set; }
        public DbSet<Partner> Partners { get; set; }
        public DbSet<PriceGroup> PriceGroups { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<TypeOfItem> TypesOfItems { get; set; }
        public DbSet<Unit> Units { get; set; }


    }

}
