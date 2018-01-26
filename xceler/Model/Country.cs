using System;
namespace xceler.Model
{
    public class Country
    {
        public int CountryId { get; set; }
        public string CountryCode { get; set; }
        public string ISO { get; set; }
        public string ISO3 { get; set; }
        public string Name { get; set; }
        public string NiceName { get; set; }
        public string NumCode { get; set; }
        public bool Active { get; set; }
    }
}
