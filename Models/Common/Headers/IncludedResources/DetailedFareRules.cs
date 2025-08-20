using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmadeusIntegration.Models.Headers
{
    public class DetailedFareRules
    {
        [JsonProperty("fareBasis")]
        public string FareBasis { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("fareNotes")]
        public TermsAndCondition TermsAndConditions { get; set; }

        [JsonProperty("segmentId")]
        public string SegmentId { get; set; }
    }

    public struct TermsAndCondition
    {

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("circumstances")]
        public string Circumstances { get; set; }

        [JsonProperty("notApplicable")]
        public bool NotApplicable { get; set; }

        [JsonProperty("maxPenaltyAmount")]
        public string MaxPenaltyAmount { get; set; }

        [JsonProperty("discriptions")]
        public List<Discription> Discriptions { get; set; }


    }
    public struct Discription
    {
        [JsonProperty("descriptionType")]
        public string DescriptionType { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

    }
}