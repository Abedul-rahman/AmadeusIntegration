using AmadeusIntegration.Models.Enums;
using Newtonsoft.Json;

namespace AmadeusIntegration.Models
{
    public class FlightSearchGetRequest
    {
        [JsonRequired]
        public string Origin { get; set; }

        [JsonRequired]
        public string Destination { get; set; }

        [JsonRequired]
        public string DepartureDate { get; set; }

        public string ReturnDate { get; set; }

        [JsonRequired]
        public int Adults { get; set; }

        public int? Children { get; set; }
        public int? Infants { get; set; }
        public ETravelClassType? TravelClass { get; set; }
        public string[] IncludedAirlineCodes { get; set; }
        public string[] ExcludedAirlineCodes { get; set; }
        public string Currency { get; set; }
        public bool NonStop { get; set; } = false;
        public string MaxPrice { get; set; }
        public int? Max { get; set; } = 250;
    }

}
