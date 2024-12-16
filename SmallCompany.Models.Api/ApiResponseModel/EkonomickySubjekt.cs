namespace SmallCompany.Models.Api.ApiResponseModel
{
    public class EkonomickySubjekt
    {
        public string? Ico { get; set; } //maxLength: 8, minLength: 8, pattern: ^\d{8}$
        public string? ObchodniJmeno { get; set; } //maxLength: 2000, minLength: 1
        public Adresa Sidlo { get; set; } = new Adresa();
        public string? PravniForma { get; set; }
        public string? FinancniUrad { get; set; }
        public string? DatumVzniku { get; set; }
        public string? DatumZaniku { get; set; }
        public string? DatumAktualizace { get; set; }
        public string? Dic { get; set; }
        public string? IcoId { get; set; }
        public AdresaDorucovaci AdresaDorucovaci { get; set; } = new AdresaDorucovaci();
        public string? PrimarniZdroj { get; set; }
        public List<EkonomickySubjektDalsiUdaje> DalsiUdaje { get; set; } = new List<EkonomickySubjektDalsiUdaje>();
        public List<string> CzNace { get; set; } = new List<string>();
        public string? SubRegistrSzr { get; set; }
        public string? DicSkDph { get; set; }
    }
}
