using Newtonsoft.Json;
using System.Collections.Generic;

namespace AmadeusIntegration.Models
{
    public class FlightPriceRequest
    {
        [JsonProperty("data")]
        public FlightPriceRequestData Data { get; set; }
        public FlightPriceRequest(List<FlightOffer> Data)
        {
            this.Data = new FlightPriceRequestData
            {
                FlightOffers = Data
            };
        }
        

    }

    public class FlightPriceRequestData
    {
        [JsonProperty("type")]
        [JsonRequired]
        public string Type { get; set; } = "flight-offers-pricing";

        [JsonProperty("flightOffers")]
        [JsonRequired]
        public List<FlightOffer> FlightOffers { get; set; }

        [JsonProperty("payments")]
        public List<Payment> Payments { get; set; }

        [JsonProperty("travelers")]
        public List<TravelerElement> Travelers { get; set; }
        
    }

}
