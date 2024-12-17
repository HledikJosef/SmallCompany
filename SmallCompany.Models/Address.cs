namespace SmallCompany.Models
{
    public class Address
    {
        public int Id { get; set; }
        public State State { get; set; } = null!;
        public string City { get; set; } = string.Empty;
        public string? CityPart { get; set; } = string.Empty;
        public string? Street { get; set; } = string.Empty;
        /// <summary>
        /// číslo popisné
        /// </summary>
        public int HouseNr { get; set; }
        /// <summary>
        /// číslo orientační
        /// </summary>
        public int? OrientationNr { get; set; }
        /// <summary>
        /// číslo orientační-písmeno
        /// </summary>
        public string? OrientationNrLetter { get; set; } = string.Empty;
        public string PscTxt { get; set; } = string.Empty;
        public bool IsActive { get; set; }
    }
}
