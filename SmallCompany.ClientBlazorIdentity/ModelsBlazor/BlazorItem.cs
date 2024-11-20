using System.ComponentModel.DataAnnotations;

namespace SmallCompany.ClientBlazorIdentity.ModelsBlazor
{
    public class BlazorItem
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Název položky musí být vyplněna a její délka musí být max 25 znaků."), MaxLength(25, ErrorMessage = "Maximální délka názvu je 15 znaků.")]
        public string Name { get; set; } = String.Empty;
        [Required(ErrorMessage = "Jednotka položky musí být zvolena.")]
        public int UnitId { get; set; }
        [Required(ErrorMessage = "Typ položky musí být zvolen.")]
        public int TypeOfItemId { get; set; }

        public List<BlazorProperty> ItemProperties { get; set; } = new List<BlazorProperty>();
    }
}
