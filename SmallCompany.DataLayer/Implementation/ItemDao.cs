using Microsoft.EntityFrameworkCore;
using SmallCompany.Models;
using SmallCompany.Models.Data;
using System.Data;
using System.Data.SqlClient;

namespace SmallCompany.DataLayer.Implementation
{
	public class ItemDao : IItemDao
	{
		private readonly ApplicationDbContext context;
		private readonly string connectionString;
		public ItemDao(ApplicationDbContext context)
		{
			this.context = context;
			connectionString = context.Database.GetDbConnection().ConnectionString;
		}

		public async Task<List<Item>> GetItemsFromSqlAsync()
		{
			List<Item> itemsFromSql = new List<Item>();
			itemsFromSql = await context.Items.ToListAsync();

			return itemsFromSql;
		}

		public async Task AddItemWithPropertiesToDbAsync(Item itemWithProperties)
		{
			List<Item> existingItems = await CheckExistingItemAsync(itemWithProperties);

			if (existingItems.Count() == 0)
			{
				await context.Items.AddAsync(itemWithProperties);
				await context.SaveChangesAsync();
			}
		}

		private async Task<List<Item>> CheckExistingItemAsync(Item item)
		{
			List<Item> existingItems = new List<Item>();

			string sqlQuery = @"SELECT i.Id FROM Items i INNER JOIN ItemsPropertyValue ipv ON i.Id = ipv.ItemId WHERE i.Name = @Name";

			int index = 1;

			foreach (var ipv in item.ItemPropertyValues)
			{
				sqlQuery += ($" AND EXISTS( SELECT 1 FROM ItemsPropertyValue ipv{index} WHERE ipv{index}.ItemId = i.Id AND ipv{index}.PropertyId = @PropertyId{index} AND ipv{index}.Value = @Value{index} )");

				index++;
			}

			index = 1;

			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				using (SqlCommand command = new SqlCommand(sqlQuery, connection))
				{

					command.Parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar));
					command.Parameters["@Name"].Value = item.Name;

					foreach (var ipv in item.ItemPropertyValues)
					{
						command.Parameters.Add(new SqlParameter($"@PropertyId{index}", SqlDbType.Int));
						command.Parameters[$"@PropertyId{index}"].Value = ipv.PropertyId;

						command.Parameters.Add(new SqlParameter($"@Value{index}", SqlDbType.NVarChar));
						command.Parameters[$"@Value{index}"].Value = ipv.Value;

						index++;
					}
					await connection.OpenAsync();

					using (var reader = await command.ExecuteReaderAsync())
					{
						while (reader.Read())
						{
							Item existingItem = new Item
							{
								Id = reader.GetInt32(reader.GetOrdinal("Id")),
							};
							existingItems.Add(existingItem);

						}

					}


				}

			}


			return existingItems;
		}



	}
}

