using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AmadeusIntegration.Models
{
    public class TravelerRequirement
    {
        [JsonProperty("travelerId")]
        public string TravelerId { get; set; }

        [JsonProperty("genderRequired")]
        public bool GenderRequired { get; set; }

        [JsonProperty("documentRequired")]
        public bool DocumentRequired { get; set; }

        [JsonProperty("dateOfBirthRequired")]
        public bool DateOfBirthRequired { get; set; }

        [JsonProperty("redressRequiredIfAny")]
        public bool RedressRequiredIfAny { get; set; }

        [JsonProperty("residenceRequired")]
        public bool ResidenceRequired { get; set; }
    }

}
