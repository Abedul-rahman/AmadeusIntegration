using AmadeusIntegration.Models.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmadeusIntegration.Models
{
    public class Discount
    {
        [JsonProperty("subType")]
        public EDiscountType SubType { get; set; }

        [JsonProperty("cityName")]
        public string CityName { get; set; }

        [JsonProperty("travelertype")]
        public EDiscountType TravelerType { get; set; }

        [JsonProperty("cardNumber")]
        public string CardNumber { get; set; }

        [JsonProperty("certificateNumber")]
        public string CertificateNumber { get; set; }
    }
}
