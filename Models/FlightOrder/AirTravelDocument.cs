using AmadeusIntegration.Models.Enums;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AmadeusIntegration.Models
{
    public class AirTravelDocument
    {
        [JsonProperty("documentType")]
        public EDocumentType DocumentType { get; set; }

        [JsonProperty("documentNumber")]
        public string DocumentNumber { get; set; }

        [JsonProperty("documentStatus")]
        public EDocumentStatus DocumentStatus { get; set; }

        [JsonProperty("travelerId")]
        public string TravelerId { get; set; }

        [JsonProperty("segmentsId")]
        public List<string> SegmentsId { get; set; }
    }
}
