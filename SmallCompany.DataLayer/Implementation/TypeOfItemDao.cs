﻿using Microsoft.EntityFrameworkCore;
using SmallCompany.Models;
using SmallCompany.Models.Data;

namespace SmallCompany.DataLayer.Implementation
{
    public class TypeOfItemDao : ITypeOfItemDao
    {
        private readonly ApplicationDbContext context;

        public TypeOfItemDao(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<List<TypeOfItem>> GetTypeOfItemsFromDbAsync()
        {
            List<TypeOfItem> typeOfItemsFromSql = new List<TypeOfItem>();
            typeOfItemsFromSql = await context.TypesOfItems.ToListAsync();

            return typeOfItemsFromSql;
        }

        public async Task AddTypeOfItemToDbAsync(TypeOfItem typeOfItem)
        {
            await context.TypesOfItems.AddAsync(typeOfItem);
            await context.SaveChangesAsync();
        }

        public async Task UpdateTypeOfItemInDbAsync(TypeOfItem typeOfItem)
        {
            TypeOfItem? typeOfItemToUpdate = (TypeOfItem?)await context.FindAsync(typeof(TypeOfItem), typeOfItem.Id)
                ?? throw new InvalidOperationException();

            context.Entry(typeOfItemToUpdate).CurrentValues.SetValues(typeOfItem);
            await context.SaveChangesAsync();
        }
    }
}
