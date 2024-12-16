using System.ComponentModel.DataAnnotations;

namespace SmallCompany.ClientBlazorIdentity.ModelsBlazor
{
    public class IcoForApi
    {
        [Required(ErrorMessage = "Ičo musí být vyplněno."),
         Length(8, 8, ErrorMessage = "Ičo musí mít délku 8 znaků. Případně doplňte nuly zleva."),
         RegularExpression(@"^\d+$", ErrorMessage = "Hodnota musí obsahovat pouze číslice.")]
        public string Ico { get; set; } = string.Empty;
    }
}
