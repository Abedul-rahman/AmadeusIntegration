using AmadeusIntegration.Models.Enums;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AmadeusIntegration.Models
{
    public class TravelerPricing
    {
        [JsonRequired]
        [JsonProperty("travelerId")]
        public string TravelerId { get; set; }

        [JsonProperty("fareOption")]
        [JsonRequired]
        public EFareOption FareOption { get; set; }

        [JsonRequired]
        [JsonProperty("travelerType")]
        public  ETravelerType TravelerType { get; set; }
        /// <summary>
        /// if type="HELD_INFANT", corresponds to the adult traveler's id who will share the seat
        /// </summary>
        [JsonProperty("associatedAdultId")]
        public string AssociatedAdultId { get; set; }


        [JsonProperty("price")]
        public SPrice Price { get; set; }

        [JsonProperty("fareDetailsBySegment")]
        [JsonRequired]
        public List<FareDetailsBySegment> FareDetailsBySegment { get; set; }
    }

    public struct SPrice {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("total")]
        public string Total { get; set; }

        [JsonProperty("base")]
        public string Base { get; set; }

        [JsonProperty("fees")]
        public List<Fee> Fees { get; set; }

        [JsonProperty("taxes")]
        public List<Tax> Taxes { get; set; }

        [JsonProperty("refundableTaxes")]
        public string RefundableTaxes { get; set    ; }

    }


}

