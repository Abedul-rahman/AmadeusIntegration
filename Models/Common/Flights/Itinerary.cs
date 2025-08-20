using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmadeusIntegration.Models
{
    public class Itinerary
    {

        /// <summary>
        ///	string
        ///example: PT2H10M
        ///duration in ISO8601 PnYnMnDTnHnMnS format, e.g.PT2H10M for a duration of 2h10m
        ///</summary>
        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("segments")]
        [JsonRequired]
        public List<Segment> Segments { get; set; }
    

    }
}
