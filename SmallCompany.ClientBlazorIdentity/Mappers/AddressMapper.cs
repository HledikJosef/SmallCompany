using SmallCompany.ClientBlazorIdentity.ModelsBlazor;
using SmallCompany.Models.Api.ApiResponseModel;

namespace SmallCompany.ClientBlazorIdentity.Mappers
{
    public static class AddressMapper
    {
        public static BlazorAddress MapAddress(Adresa adresa)
        {
            BlazorAddress address = new BlazorAddress();
            address.State.Name = adresa.NazevStatu;
            address.State.Code = adresa.KodStatu;
            address.City = adresa.NazevObce;
            address.CityPart = adresa.NazevCastiObce;
            address.Street = adresa.NazevUlice;
            address.HouseNr = adresa.CisloDomovni;
            address.OrientationNr = adresa.CisloOrientacni;
            address.OrientationNrLetter = adresa.CisloOrientacniPismeno;
            address.PscTxt = adresa.Psc.ToString();

            return address;
        }

        public static BlazorDeliveryAddress MapDeliveryAddress(AdresaDorucovaci adresa)
        {
            BlazorDeliveryAddress deliveryAddress = new BlazorDeliveryAddress();
            deliveryAddress.AddressRow1 = adresa.RadekAdresy1;
            deliveryAddress.AddressRow2 = adresa.RadekAdresy2;
            deliveryAddress.AddressRow3 = adresa.RadekAdresy3;

            return deliveryAddress;
        }
    }
}
