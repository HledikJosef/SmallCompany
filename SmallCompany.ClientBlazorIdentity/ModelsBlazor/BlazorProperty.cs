using System.ComponentModel.DataAnnotations;

namespace SmallCompany.ClientBlazorIdentity.ModelsBlazor
{
    public class BlazorProperty
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Název vlastnosti musí být vyplněn a jeho délka musí být max 25 znaků."), MaxLength(25, ErrorMessage = "Maximální délka hodnoty je 25 znaků.")]
        public string Name { get; set; } = String.Empty;
        [Required, Range(1, int.MaxValue, ErrorMessage = "Datový typ vlastnosti musí být přiřazen.")]
        public int BlazorDateTypeId { get; set; }
        public string Value { get; set; } = String.Empty; //mapovat do ItemPropertyValue!!
        public bool IsActive { get; set; }

        public BlazorDateType BlazorDateType { get; set; } = new();


        public BlazorProperty CopyProperty()
        {
            return (BlazorProperty)MemberwiseClone();
        }


    }
}
