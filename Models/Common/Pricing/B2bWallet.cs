using AmadeusIntegration.Models.Enums;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AmadeusIntegration.Models
{
    public class B2bWallet
    {
        [JsonProperty("cardId")]
        public string CardId { get; set; }

        [JsonProperty("cardUsageName")]
        public string CardUsageName { get; set; }

        [JsonProperty("cardFriendlyName")]
        public string CardFriendlyName { get; set; }

        [JsonProperty("reportingData")]
        public List<ReportingData> ReportingData { get; set; }

        [JsonProperty("virtualCreditCardDetails")]
        public CreditCardCommon VirtualCreditCardDetails { get; set; }

        [JsonProperty("flightOfferIds")]
        public List<string> FlightOfferIds { get; set; }
    }

    public struct ReportingData
    {
        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("value")]
        public string value { get; set; }
    }

    public class CreditCardCommon
    {
        [JsonProperty("brand")]
        public ECreditCardBrand Brand { get; set; }

        [JsonProperty("holder")]
        public string Holder { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("amount")]
        public string Amount { get; set; }

        [JsonProperty("currencyCode")]
        public string CurrencyCode { get; set; }
    }   
}
