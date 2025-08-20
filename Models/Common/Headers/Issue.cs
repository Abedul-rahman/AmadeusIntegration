using Newtonsoft.Json;

namespace AmadeusIntegration.Models.Headers
{
    public class Issue
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("detail")]
        public string Detail { get; set; }

        [JsonProperty("source")]
        public Source Source { get; set; }
    }

    public struct Source
    {
        [JsonProperty("pointer")]
        public string Pointer { get; set; }

        [JsonProperty("parameter")]
        public string Parameter { get; set; }

        [JsonProperty("example")]
        public string Example { get; set; }
    }
}
