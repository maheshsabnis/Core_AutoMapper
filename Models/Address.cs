namespace Core_AutoMapper.Models
{
    public class Address
    {
        public string? BuildingOrSocietyName { get; set; }
        public string? BuindingNoFlatNo { get; set; }
        public string? Area { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public override  string ToString()
        {
            return $"{BuildingOrSocietyName}, {BuindingNoFlatNo}, {Area}, {City}, {State}";
        }
    }
}
