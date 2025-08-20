using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmadeusIntegration.Models
{
    public class Adress
    {
        [JsonProperty("line")]
        public List<string> Lines { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        /// <summary>
        /// ISO 3166-1 country code
        /// </summary>
        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("cityName")]
        public string CityName { get; set; }

        [JsonProperty("stateName")]
        public string StateName { get; set; }

        [JsonProperty("postalBox")]
        public string PostalBox { get; set; }

    }
}
