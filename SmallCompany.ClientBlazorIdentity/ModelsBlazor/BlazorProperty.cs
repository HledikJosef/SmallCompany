using System.ComponentModel.DataAnnotations;

namespace SmallCompany.ClientBlazorIdentity.ModelsBlazor
{
	public class BlazorProperty
	{
		public int Id { get; set; }
		[Required(ErrorMessage = "Název vlastnosti musí být vyplněn.")]
		public string Name { get; set; } = String.Empty;
		[Required(ErrorMessage = "Datový typ vlastnosti musí být přiřazen.")]
		public int BlazorDateTypeId { get; set; } //např. text(string), číslo(float)..
		public string Value { get; set; } = String.Empty; //mapovat do ItemPropertyValue!!

	}
}
