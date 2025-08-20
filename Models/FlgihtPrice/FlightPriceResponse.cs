using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AmadeusIntegration.Models.Headers;

namespace AmadeusIntegration.Models
{
    public class FlightPriceResponse

    {
        [JsonProperty("warnings")]
        public List<Issue> Warnings { get; set; }



        [JsonProperty("data")]
        public FlightPriceResponseData Data { get; set; }

        [JsonProperty("included")]
        public IncludedResourcesMap Included { get; set; }

        [JsonProperty("dictionaries")]
        public Dictionaries Dictionaries { get; set; }
    }

    public class FlightPriceResponseData
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("flightOffers")]
        public List<FlightOffer> FlightOffers { get; set; }

        [JsonProperty("bookingRequirements")]
        public BookingRequirements BookingRequirements { get; set; }
    }

}
