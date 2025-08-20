using AmadeusIntegration.Models.Enums;
using Newtonsoft.Json;


namespace AmadeusIntegration.Models
{
    public class AdditionalService
    {
        [JsonProperty("amount")]
        public string amount { get; set; }

        [JsonProperty("type")]
        public EAdditionalServiceType Type { get; set; }
    }
}
