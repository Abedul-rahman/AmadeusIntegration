using AmadeusIntegration.Models.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;

namespace AmadeusIntegration.Models
{
    public class TravelerElement
    {
        [JsonProperty("id")]
        public string Id { get; set; }

       
        [JsonProperty("dateOfBirth")]
        public string DateOfBirth { get; set; }

        [JsonProperty("gender")]
        public EGender Gender { get; set; }

        [JsonProperty("name")]
        public Name Name { get; set; }

        [JsonProperty("documents")]
        public List<TravelerDocument> Documents { get; set; }

        [JsonProperty("emergencyContact")]
        public EmergencyContact EmergencyContact { get; set; }

        [JsonProperty("loyaltyPrograms")]
        public List<LoyaltyProgram> LoyaltyPrograms { get; set; }

        [JsonProperty("discountEligibility")]
        public List<Discount> DiscountEligibility { get; set; }
        public Contact Contact { get; set; }
    }
    

}
