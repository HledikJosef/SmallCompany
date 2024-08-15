using System.ComponentModel.DataAnnotations;

namespace SmallCompany.ClientBlazorIdentity.ModelsBlazor
{
    public class BlazorStock
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Název skladu musí být vyplněn a jeho maximální délka musí být 25 znaků."), MaxLength(25, ErrorMessage = "Maximální délka musí být 25 znaků.")]
        public string Name { get; set; } = String.Empty;
        [Required(ErrorMessage = "Lokace skladu musí být vyplněna a její maximální délka musí být 25 znaků."), MaxLength(25, ErrorMessage = "Maximální délka musí být 25 znaků.")]
        public string Location { get; set; } = String.Empty;
        [Required(ErrorMessage = "Popis skladu musí být vyplněn a jeho maximální délka musí být 50 znaků."), MaxLength(50, ErrorMessage = "Maximální délka musí být 50 znaků.")]
        public string Description { get; set; } = String.Empty;
    }
}
