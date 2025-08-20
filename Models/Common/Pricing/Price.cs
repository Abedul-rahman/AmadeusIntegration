using Newtonsoft.Json;
using System.Collections.Generic;

namespace AmadeusIntegration.Models
{
    public class Price
    {
        [JsonProperty("margin")]
        public string Margin { get; set; }

        [JsonProperty("grandTotal")]
        public string GrandTotal { get; set; }

        [JsonProperty("billingCurrency")]
        public string BillingCurrency { get; set; }

        [JsonProperty("additionalServices")]
        public List<AdditionalService> AdditionalServices { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("total")]
        public string Total { get; set; }

        [JsonProperty("base")]
        public string Base { get; set; }

        [JsonProperty("fees")]
        public List<Fee> Fees { get; set; }

        [JsonProperty("taxes")]
        public List<Tax> Taxes { get; set; }

        [JsonProperty("refundableTaxes")]
        public string RefundableTaxes { get; set; }

    }
}
