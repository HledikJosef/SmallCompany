namespace SmallCompany.Models.Api.ApiResponseModel
{
    public class Adresa
    {
        public string? KodStatu { get; set; } //maxLength: 3, minLength: 3
        public string? NazevStatu { get; set; } //maxLength: 32
        public int KodKraje { get; set; }
        public string? NazevKraje { get; set; }
        public int KodOkresu { get; set; }
        public string? NazevOkresu { get; set; }
        public int KodObce { get; set; }
        public string? NazevObce { get; set; }
        public int KodSpravnihoObvodu { get; set; }
        public string? NazevSpravnihoObvodu { get; set; }
        public int KodMestskehoObvodu { get; set; }
        public string? NazevMestskehoObvodu { get; set; }
        public int KodMestskeCastiObvodu { get; set; }
        public int KodUlice { get; set; }
        public string? NazevMestskeCastiObvodu { get; set; }
        public string? NazevUlice { get; set; }
        public int CisloDomovni { get; set; }
        public string? DoplnekAdresy { get; set; }
        public int KodCastiObce { get; set; }
        public int CisloOrientacni { get; set; }
        public string? CisloOrientacniPismeno { get; set; }
        public string? NazevCastiObce { get; set; }
        public int KodAdresnihoMista { get; set; }
        public int Psc { get; set; }
        public string? TextovaAdresa { get; set; }
        public string? CisloDoAdresy { get; set; }
        public bool StandardizaceAdresy { get; set; }
        public string? PscTxt { get; set; }
        public int TypCisloDomovni { get; set; }
    }
}
