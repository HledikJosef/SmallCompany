namespace SmallCompany.DataLayer
{
	public class ItemModel
	{
		public int ItemId { get; set; }
		public string ItemTitle { get; set; }
		public string ItemDescription { get; set; }

		public ItemPropertiesModel itemProperties = new ItemPropertiesModel();
		public MaterialModel itemMaterial = new MaterialModel();


	}
}
