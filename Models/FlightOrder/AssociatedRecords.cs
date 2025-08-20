using Newtonsoft.Json;

namespace AmadeusIntegration.Models
{
    public class AssociatedRecords
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("creationDate")]
        public string CreationDate { get; set; }

        [JsonProperty("originSystemCode")]
        public string OriginSystemCode { get; set; }

        [JsonProperty("flightOfferId")]
        public string FlightOfferId { get; set; }
    }
}
