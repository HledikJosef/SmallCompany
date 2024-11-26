using Microsoft.EntityFrameworkCore;
using SmallCompany.Models;
using SmallCompany.Models.Data;

namespace SmallCompany.DataLayer.Implementation
{
    public class DateTypeDao : IDateTypeDao
    {
        private readonly ApplicationDbContext context;

        public DateTypeDao(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<List<DateType>> GetDateTypesFromDbAsync()
        {
            List<DateType> dateTypesFromSql = new List<DateType>();
            dateTypesFromSql = await context.DateTypes.ToListAsync();

            return dateTypesFromSql;
        }

        public async Task AddDateTypeToDbAsync(DateType dateType)
        {
            await context.DateTypes.AddAsync(dateType);
            await context.SaveChangesAsync();
        }

        public async Task UpdateDateTypeInDbAsync(DateType dateType)
        {
            DateType? dateTypeToChange = (DateType?)await context.FindAsync(typeof(DateType), dateType.Id)
                ?? throw new InvalidOperationException();

            context.Entry(dateTypeToChange).CurrentValues.SetValues(dateType);

            await context.SaveChangesAsync();
        }

        public async Task<DateType> CheckDateTypeDuplicity(DateType dateTypeToCheck)
        {
            DateType? existingDateType = existingDateType = await context.DateTypes.Where(dt => dt.Name == dateTypeToCheck.Name).FirstOrDefaultAsync()
                ?? throw new InvalidOperationException();

            return existingDateType;
        }
    }
}
