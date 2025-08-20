using Newtonsoft.Json;

namespace AmadeusIntegration.Models
{
    
    public class EmergencyContact
    {
        [JsonProperty("addresseeName")]
        public string AddresseeName { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

    }
}
