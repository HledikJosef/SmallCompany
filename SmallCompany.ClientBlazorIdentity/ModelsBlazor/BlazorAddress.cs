namespace SmallCompany.ClientBlazorIdentity.ModelsBlazor
{
    public class BlazorAddress
    {
        public int Id { get; set; }
        public BlazorState State { get; set; } = new BlazorState();
        public string City { get; set; } = string.Empty;
        public string CityPart { get; set; } = string.Empty;
        public string Street { get; set; } = string.Empty;
        /// <summary>
        /// číslo popisné
        /// </summary>
        public int? HouseNr { get; set; }
        /// <summary>
        /// číslo orientační
        /// </summary>
        public int? OrientationNr { get; set; }
        /// <summary>
        /// číslo orientační-písmeno
        /// </summary>
        public string OrientationNrLetter { get; set; } = string.Empty;
        public string PscTxt { get; set; } = string.Empty;
        public bool IsActive { get; set; }
    }
}
