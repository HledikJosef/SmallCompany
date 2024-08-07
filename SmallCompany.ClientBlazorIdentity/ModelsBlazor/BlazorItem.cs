namespace SmallCompany.ClientBlazorIdentity.ModelsBlazor
{
    public class BlazorItem
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public int UnitId { get; set; }
        public int TypeOfItemId { get; set; }
        public BlazorUnit BlazorUnit { get; set; } = new BlazorUnit();
        public BlazorTypeOfItem BlazorTypeOfItem { get; set; } = new BlazorTypeOfItem();
        public List<BlazorItemPropertyValue> BlazorItemPropertyValues { get; } = new List<BlazorItemPropertyValue>();
    }
}
