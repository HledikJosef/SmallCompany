namespace SmallCompany.Models.Api.ApiResponseModel
{
    public class EkonomickySubjektDalsiUdaje
    {
        public List<ObchodniJmenoAres>? ObchodniJmeno { get; set; }
        public List<AdresaAres>? Sidlo { get; set; }
        public string? PravniForma { get; set; }
        public string? SpisovaZnacka { get; set; }
        public string? DatovyZdroj { get; set; }
    }
}
