using AmadeusIntegration.Models.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AmadeusIntegration.Models
{
    public class Segment
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("numberOfStops")]
        public int NumberOfStops { get; set; }

        [JsonProperty("blacklistedInEU")]
        public bool BlacklistedInEU { get; set; }

        [JsonProperty("co2emission")]
        public List<CO2Emission> CO2Emission { get; set; }


        [JsonProperty("departure")]
        public FlightPoint Departure { get; set; }

        [JsonProperty("arrival")]
        public FlightPoint Arrival { get; set; }

        [JsonProperty("carrierCode")]
        public string CarrierCode { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("aircraft")]
        public Aircraft Aircraft {get; set;}

        [JsonProperty("operating")]
        public Operating Operating { get; set; }

        /// <summary>
        ///	string
        ///example: PT2H10M
        ///duration in ISO8601 PnYnMnDTnHnMnS format, e.g.PT2H10M for a duration of 2h10m
        ///</summary>
        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("stops")]
        public List<FlightStop>Stops { get; set; }


    }

    public struct CO2Emission
    {
        public int Weight { get; set; }
        public string WeightUnit { get; set; }
        public ETravelClassType Cabin { get; set; }

    }
    public struct FlightStop  
    {
        [JsonProperty("arrivalAt")]
        public DateTime ArrivalAt { get; set; }

        /// <summary>
        ///	string
        ///example: PT2H10M
        ///duration in ISO8601 PnYnMnDTnHnMnS format, e.g.PT2H10M for a duration of 2h10m
        ///</summary>
        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("departureAt")]
        public DateTime DepartureAt { get; set; }

        [JsonProperty("iataCode")]
        public string IataCode { get; set; }
    }
    

}
