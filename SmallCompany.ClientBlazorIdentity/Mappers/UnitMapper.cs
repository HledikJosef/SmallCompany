using SmallCompany.ClientBlazorIdentity.ModelsBlazor;
using SmallCompany.Models;

namespace SmallCompany.ClientBlazorIdentity.Mappers
{
    public static class UnitMapper
    {
        public static BlazorUnit MapUnit(Unit unit)
        {
            BlazorUnit blazorUnit = new BlazorUnit();
            blazorUnit.Id = unit.Id;
            blazorUnit.Name = unit.Name;

            return blazorUnit;
        }

        public static Unit MapUnit(BlazorUnit blazorUnit)
        {
            Unit unit = new Unit();
            unit.Id = blazorUnit.Id;
            unit.Name = blazorUnit.Name;

            return unit;
        }
    }
}
