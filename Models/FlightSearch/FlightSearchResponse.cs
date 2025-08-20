
using AmadeusIntegration.Models.Headers;
using Newtonsoft.Json;
using System.Collections.Generic;
namespace AmadeusIntegration.Models
{
    public class FlightSearchResponse
    {
        [JsonProperty("warnings")]
        public List<Issue> Warnings { get; set; }

        [JsonProperty("meta")]
        public Meta Meta { get; set; }

        [JsonProperty("data")]
        public List<FlightOffer> Data { get; set; }

        [JsonProperty("dictionaries")]
        public Dictionaries Dictionaries { get; set; }
    }

}
