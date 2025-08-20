using Newtonsoft.Json;
using System.Collections.Generic;
using AmadeusIntegration.Models.Enums;
namespace AmadeusIntegration.Models
{
    public class Remarks
    {
        [JsonProperty("general")]
        public List<GeneralRemark> General { get; set; }

        [JsonProperty("airline")]
        public List<AirLineRemark> AirLines { get; set; }
    }

    public struct GeneralRemark
    {
        [JsonRequired]
        [JsonProperty("subType")]
        public EGeneralRemarkType  SubType{ get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonRequired]
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("travelerIds")]
        public List<string> TravelerIds { get; set; }

        [JsonProperty("flightOfferIds")]
        public List<string> FlightOfferIds { get; set; }


    }

    public struct AirLineRemark
    {
        [JsonRequired]
        [JsonProperty("subType")]
        public EAirlineRemarkType SubType { get; set; }

        [JsonProperty("keyword")]
        public string Keyword { get; set; }

        [JsonRequired]
        [JsonProperty("airlineCode")]
        public string AirlineCode { get; set; }

        [JsonRequired]
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("travelerIds")]
        public List<string> TravelerIds { get; set; }
        [JsonProperty("flightOfferIds")]
        public List<string> FlightOfferIds { get; set; }
    }
}
