using AmadeusIntegration.Models.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmadeusIntegration.Models
{
    public class PricingOptions
    {
        [JsonProperty("fareType")]
        public List<EPricingOptionsFareType> FareType { get; set; }

        [JsonProperty("includedCheckedBagsOnly")]
        public bool IncludedCheckedBagsOnly { get; set; }

        [JsonProperty("refundableFare")]
        public bool RefundableFare { get; set; }

        [JsonProperty("noRestrictionFare")]
        public bool NoRestrictionFare { get; set; }

        [JsonProperty("noPenaltyFare")]
        public bool NoPenaltyFare { get; set; }


    }
}
