using SmallCompany.ClientBlazorIdentity.ModelsBlazor;
using SmallCompany.Models.Api.ApiResponseModel;

namespace SmallCompany.ClientBlazorIdentity.Mappers
{
    public static class PartnerMapper
    {

        public static BlazorPartner MapPartner(EkonomickySubjekt ekonomickySubjekt)
        {
            BlazorPartner partner = new BlazorPartner();
            partner.Name = ekonomickySubjekt.ObchodniJmeno;
            partner.Ico = ekonomickySubjekt.Ico;
            partner.Dic = ekonomickySubjekt.Dic;
            partner.Address = AddressMapper.MapAddress(ekonomickySubjekt.Sidlo);
            partner.DeliveryAddress = AddressMapper.MapDeliveryAddress(ekonomickySubjekt.AdresaDorucovaci);

            return partner;
        }
    }
}
