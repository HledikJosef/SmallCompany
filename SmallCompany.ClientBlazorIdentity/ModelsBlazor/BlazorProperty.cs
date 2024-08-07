namespace SmallCompany.ClientBlazorIdentity.ModelsBlazor
{
    public class BlazorProperty
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;

        public int BlazorDateTypeId { get; set; } //např. text(string), číslo(float)..
        public BlazorDateType BlazorDateType { get; set; } = new BlazorDateType();
        public List<BlazorItemPropertyValue> BlazorItemPropertyValues { get; } = new List<BlazorItemPropertyValue>();
    }
}
