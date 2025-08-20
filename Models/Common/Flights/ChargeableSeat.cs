using Newtonsoft.Json;

namespace AmadeusIntegration.Models
{
    public class ChargeableSeat
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

    }
}
