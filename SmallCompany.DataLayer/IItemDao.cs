﻿using SmallCompany.Models;

namespace SmallCompany.DataLayer
{
    public interface IItemDao
    {
        public Task<List<Item>> GetItemsFromSqlAsync();
        public Task AddItemWithPropertiesToDbAsync(Item itemWithProperties);
        public Task<Item?> CheckExistingItemAsync(Item item);
        public Task UpdateItemInDbAsync(Item item);
    }
}
