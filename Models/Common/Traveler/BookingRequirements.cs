using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmadeusIntegration.Models
{
    public class BookingRequirements
    {
        [JsonProperty("emailAddressRequired")]
        public bool EmailAddressRequired { get; set; }

        [JsonProperty("mobilePhoneNumberRequired")]
        public bool MobilePhoneNumberRequired { get; set; }

        [JsonProperty("travelerRequirements")]
        public List<TravelerRequirement> TravelerRequirements { get; set; }
    }

   
}
