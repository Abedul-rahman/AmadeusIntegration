using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmadeusIntegration.Models.Headers
{
    public class Dictionaries
    {
        [JsonProperty("locations")]
        public Dictionary<string, LocationInfo> Locations { get; set; }

        [JsonProperty("carriers")]
        public Dictionary<string, string> Carriers { get; set; }

        [JsonProperty("aircraft")]
        public Dictionary<string, string> Aircraft { get; set; }

        [JsonProperty("currencies")]
        public Dictionary<string, string> Currencies { get; set; }
    }

    public class LocationInfo
    {
        [JsonProperty("cityCode")]
        public string CityCode { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }
    }
}
