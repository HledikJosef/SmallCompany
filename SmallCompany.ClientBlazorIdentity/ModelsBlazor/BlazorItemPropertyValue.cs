﻿using System.ComponentModel.DataAnnotations;

namespace SmallCompany.ClientBlazorIdentity.ModelsBlazor
{
    public class BlazorItemPropertyValue
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Hodnota vlastnosi musí být vyplněnaa její délka musí být max 25 znaků."), MaxLength(25, ErrorMessage = "Maximální délka hodnoty je 25 znaků.")]
        public string Value { get; set; } = String.Empty; //value může být text barva nebo číslo. V tabulce bude vše uloženo jako text.

        public int BlazorItemId { get; set; }

        public int BlazorPropertyId { get; set; }

        public BlazorItemNew BlazorItem { get; set; } = new();
        public BlazorProperty BlazorProperty { get; set; } = new();



        public BlazorItemPropertyValue CopyItemPropertyValue()
        {
            return new BlazorItemPropertyValue
            {
                Id = this.Id,
                Value = this.Value,
                BlazorItemId = this.BlazorItemId,
                BlazorPropertyId = this.BlazorPropertyId,
                BlazorItem = this.BlazorItem.CopyItem(),
                BlazorProperty = this.BlazorProperty.CopyProperty()

            };
        }
    }
}
