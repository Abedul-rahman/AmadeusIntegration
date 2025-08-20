using AmadeusIntegration.Models.Enums;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AmadeusIntegration.Models
{
    public class CreditCard
    {
        [JsonProperty("brand")]
        public ECreditCardBrand Brand { get; set; }

        [JsonProperty("holder")]
        public string Holder { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        /// <summary>
        /// Credit card expiration date following ISO 8601 (YYYY-MM format, e.g. 2012-08)
        /// </summary>
        [JsonProperty("expiryDate")]
        public string ExpiryDate { get; set; }

        [JsonProperty("securityCode")]
        public string SecurityCode { get; set; }

        [JsonProperty("flightOfferIds")]
        public List<string> FlightOfferIds { get; set; }
    }

    public struct OtherCreditCard
    {
        [JsonProperty("method")]
        public EOtherPaymentMethod Method { get; set; }

        [JsonProperty("flightOfferIds")]
        public List<string> FlightOfferIds { get; set; }
    }
}
