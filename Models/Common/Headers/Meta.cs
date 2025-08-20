using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmadeusIntegration.Models.Headers
{
    public class Meta
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("links")]
        public MetaLinks Links { get; set; }
    }

    public class MetaLinks
    {
        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("previous")]
        public string Prev { get; set; }

        [JsonProperty("last")]
        public string Last { get; set; }

        [JsonProperty("first")]
        public string First { get; set; }

        [JsonProperty("up")]
        public string Up { get; set; }
        
    }

}
