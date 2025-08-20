//using AmadeusIntegration.Models.Enums;
//using Newtonsoft.Json;
//using System.Collections.Generic;

//namespace AmadeusIntegration.Models
//{
//    //add the following properties to the class
//    //currencyCode:string 
//    //originDestinations:OriginDestination[]
//    //travelers:Traveler[]
//    //source:source[]
//    //searchCriteria:SearchCriteria
//    public class FlightSearchPostRequest
//    {
//        [JsonProperty("currencyCode")]
//        public string CurrencyCode { get; set; }

//        [JsonProperty("originDestinations")]
//        [JsonRequired]
//        public List<OriginDestination> OriginDestinations { get; set; }

//        [JsonRequired]
//        [JsonProperty("travelers")]
//        public List<ExtendedTravelerInfo> Travelers { get; set; }

//        [JsonProperty("source")]
//        [JsonRequired]
//        public List<EFlightOfferSource> Source { get; set; }

//        [JsonProperty("searchCriteria")]
//        public SearchCriteria SearchCriteria { get; set; }



//    }
//}
