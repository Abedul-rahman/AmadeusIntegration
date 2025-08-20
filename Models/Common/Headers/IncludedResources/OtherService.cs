using AmadeusIntegration.Models.Enums;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AmadeusIntegration.Models.Headers
{
    public class OtherService
    {
        [JsonProperty("name")]
        public EServiceName Name { get; set; }

        [JsonProperty("price")]
        public ElementaryPrice Price { get; set; }

        [JsonProperty("bookableByItinerary")]
        public bool BookableByItinerary { get; set; }

        [JsonProperty("bookableByTraveler")]
        public bool BookableByTraveler { get; set; }

        [JsonProperty("segmentIds")]
        public List<string> SegmentIds { get; set; }

        [JsonProperty("travelerIds")]
        public List<string> TravelerIds { get; set; }

    }
}
