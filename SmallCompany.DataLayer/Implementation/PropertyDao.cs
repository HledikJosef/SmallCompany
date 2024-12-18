﻿using Microsoft.EntityFrameworkCore;
using SmallCompany.Models;
using SmallCompany.Models.Data;

namespace SmallCompany.DataLayer.Implementation
{
    public class PropertyDao : IPropertyDao
    {
        private readonly ApplicationDbContext context;

        public PropertyDao(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<List<Property>> GetPropertiesFromDbAsync()
        {
            List<Property> propertiesFromDb = new List<Property>();
            propertiesFromDb = await context.Properties.ToListAsync();

            return propertiesFromDb;
        }

        public async Task AddPropertyToDbAsync(Property property)
        {
            await context.Properties.AddAsync(property);
            await context.SaveChangesAsync();
        }

        public async Task UpdatePropertyInDbAsync(Property property)
        {
            Property? propertyToUpdate = (Property?)await context.FindAsync(typeof(Property), property.Id)
                ?? throw new InvalidOperationException();

            context.Entry(propertyToUpdate).CurrentValues.SetValues(property);
            await context.SaveChangesAsync();
        }
    }
}
