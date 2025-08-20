using AmadeusIntegration.Models.Enums;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AmadeusIntegration.Models.Headers
{
    public class CreditCardFee
    {
        [JsonProperty("brand")]
        public EPaymentBrand Brand { get; set; }

        [JsonProperty("amount")]
        public string Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("flightOfferId")]
        public List<string> FlightOfferId { get; set; }

    }
}
