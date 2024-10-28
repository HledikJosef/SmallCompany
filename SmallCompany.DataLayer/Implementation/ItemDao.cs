using Microsoft.EntityFrameworkCore;
using SmallCompany.Models;
using SmallCompany.Models.Data;

namespace SmallCompany.DataLayer.Implementation
{
	public class ItemDao : IItemDao
	{
		private readonly ApplicationDbContext context;

		public ItemDao(ApplicationDbContext context)
		{
			this.context = context;
		}

		public async Task<List<Item>> GetItemsFromSqlAsync()
		{
			List<Item> itemsFromSql = new List<Item>();
			itemsFromSql = await context.Items.ToListAsync();

			return itemsFromSql;
		}

		public async Task AddItemWithPropertiesToDbAsync(Item itemWithProperties)
		{
			bool itemExist = false;
			List<Item> existingItems = await CheckExistingItems(itemWithProperties);

			if (!itemExist)
			{
				await context.Items.AddAsync(itemWithProperties);
				await context.SaveChangesAsync();
			}
		}

		private async Task<bool> CheckExistingItems(Item item)
		{
			bool itemExist = false;


			List<Item> existingItems = new List<Item>();
			existingItems = await context.Items.Where(i => i.Name == item.Name).Include(i => i.ItemPropertyValues).ToListAsync();


			foreach (Item existingItem in existingItems)
			{
				itemExist = existingItem.ItemPropertyValues.Count == item.ItemPropertyValues.Count &&
							existingItem.ItemPropertyValues.All(existingIpv =>
							item.ItemPropertyValues.Any(newIpv =>
							existingIpv.PropertyId == newIpv.PropertyId &&
							existingIpv.Value == newIpv.Value));

				if (itemExist)
					break;

			}

			return itemExist;

		}

		//private async Task<List<Item>> CheckExistingItems2(Item item)
		//{
		//	bool itemExist = false;

		//	var nameParam = new SqlParameter("@Name", item.Name);
		//	var propertyCountParam = new SqlParameter("@PropertyCount", item.ItemPropertyValues.Count);
		//	var uniquePropertyCountParam = new SqlParameter("@UniquePropertyCount", item.ItemPropertyValues
		//		.Select(x => new { x.PropertyId, x.Value })
		//		.Distinct().Count());

		//	var result = await context.Items.FromSqlRaw(@"WITH PropertyCounts AS (
		//												SELECT
		//													i.Id AS ItemId,
		//													COUNT(*) AS PropertyCount,
		//													COUNT(DISTINCT ipv.PropertyId, ipv.Value) AS UniquePropertyCount
		//												FROM Items i
		//												INNER JOIN ItemsPropertyValue ipv ON i.Id = ipv.ItemId
		//												WHERE i.Name = @Name
		//												GROUP BY i.Id
		//											),
		//											MatchingItems AS (
		//												SELECT
		//													i.Id
		//												FROM Items i
		//												INNER JOIN ItemsPropertyValue ipv ON i.Id = ipv.ItemId
		//												INNER JOIN PropertyCounts pc ON i.Id = pc.ItemId
		//												WHERE
		//													i.Name = @Name AND
		//													pc.PropertyCount = @PropertyCount AND
		//													pc.UniquePropertyCount = @UniquePropertyCount AND
		//													NOT EXISTS (
		//														SELECT 1
		//														FROM ItemsPropertyValue ipv2
		//														WHERE ipv2.ItemId = i.Id
		//														AND NOT EXISTS (
		//															SELECT 1
		//															FROM @ItemsPropertyValue ipv1
		//															WHERE ipv1.PropertyId = ipv2.PropertyId
		//															AND ipv1.Value = ipv2.Value
		//														)
		//													)
		//												GROUP BY i.Id
		//											)
		//											SELECT * FROM Items WHERE Id IN (SELECT Id FROM MatchingItems);

		//											", nameParam, propertyCountParam, uniquePropertyCountParam).ToListAsync();

		//	return result;

	}
}
}
