using AmadeusIntegration.Models.Enums;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AmadeusIntegration.Models
{
    public class FareDetailsBySegment
    {
        [JsonProperty("segmentId")]
        [JsonRequired]
        public string SegmentId { get; set; }

        [JsonProperty("cabin")]
        public ETravelClassType Cabin { get; set; }

        [JsonProperty("fareBasis")]
        public string FareBasis { get; set; }

        [JsonProperty("brandedFare")]
        public string BrandedFare { get; set; }

        [JsonProperty("class")]
        public string BookingClass { get; set; }

        [JsonProperty("isAllotment")]
        public bool IsAllotment { get; set; }

        [JsonProperty("allotmentDetails")]
        public AllotmentDetails AllotmentDetails { get; set; }

        [JsonProperty("sliceDiceIndicator")]
        public ESliceAndDiceIndicator SliceDiceIndicator { get; set; }

        [JsonProperty("includedCheckedBags")]
        public BaggageAllowance IncludedCheckedBags { get; set; }

        [JsonProperty("additionalServices")]
        public AdditionalServicesRequest AdditionalServices { get; set; }



    }
  

    public struct AllotmentDetails
    {
        [JsonProperty("tourName")]
        public string TourName { get; set; }

        [JsonProperty("tourReference")]
        public string TourReference { get; set; }
    }

}
