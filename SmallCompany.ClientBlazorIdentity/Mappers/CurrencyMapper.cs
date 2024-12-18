using SmallCompany.ClientBlazorIdentity.ModelsBlazor;
using SmallCompany.Models;

namespace SmallCompany.ClientBlazorIdentity.Mappers
{
    public static class CurrencyMapper
    {

        public static BlazorCurrency MapCurrency(Currency currency)
        {
            BlazorCurrency blazorCurrency = new BlazorCurrency();
            blazorCurrency.Id = currency.Id;
            blazorCurrency.Name = currency.Name;
            blazorCurrency.Code = currency.Code;

            return blazorCurrency;
        }

        public static Currency MapCurrency(BlazorCurrency blazorCurrency)
        {
            Currency currency = new Currency();
            currency.Id = blazorCurrency.Id;
            currency.Name = blazorCurrency.Name;
            currency.Code = blazorCurrency.Code;

            return currency;
        }

    }
}
