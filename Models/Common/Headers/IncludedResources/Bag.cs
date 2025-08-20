using AmadeusIntegration.Models.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AmadeusIntegration.Models.Headers
{
    public class Bag
    {
        [JsonProperty("quantity")]
        public int Quantity { get; set; }
        
        [JsonProperty("weight")]
        public int Weight { get; set; }

        [JsonProperty("weightUnit")]
        public EWeightUnits WeightUnit { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("price")]
        public ElementaryPrice Price { get; set; }

        [JsonProperty("bookableByItinerary")]
        public bool BookableByItinerary { get; set; }

        [JsonProperty("segmentIds")]
        public List<string> SegmentIds { get; set; }

        [JsonProperty("travelerIds")]
        public List<string > TravelerIds { get; set; }

    }
    public struct ElementaryPrice
    {
        [JsonProperty("amount")]    
        public string Amount { get; set; }

        [JsonProperty("currencyCode")]
        public string CurrencyCode { get; set; }

    }
}
