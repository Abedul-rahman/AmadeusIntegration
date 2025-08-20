using AmadeusIntegration.Models.Enums;
using Newtonsoft.Json;
using System.Collections.Generic;
using AmadeusIntegration.Models;
namespace AmadeusIntegration.Models.Headers
{
    public class IncludedResourcesMap
    {
        [JsonProperty("credit-card-fees")]
        public Dictionary <string,CreditCardFee> CreditCardFees { get; set; }

        [JsonProperty("bags")]
        public Dictionary<string,Bag> Bags { get; set; }

        [JsonProperty("other-services")]
        public Dictionary<string,OtherService> OtherServices { get; set; }

        [JsonProperty("detailed-fare-rules")]
        public Dictionary<string, DetailedFareRules> DetailedFareRules { get; set; }
    }

  
   
}
