using AmadeusIntegration.Models.Enums;
using Newtonsoft.Json;
using System.Collections.Generic;
namespace AmadeusIntegration.Models
{
    public class Payment
    {
        [JsonProperty("brand")]
        public EPaymentBrand Brand { get; set; }

        [JsonProperty("binNumber")]
        public int BinNumber { get; set; }

        [JsonProperty("flightOfferIds")]
        public List<string> FlightOfferIds { get; set; }



    }
}
