using AmadeusIntegration.Models.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmadeusIntegration.Models
{
    public class TicketingAgreement
    {
        [JsonProperty("option")]
        public ETicketingAgreementOption Option { get; set; }

        [JsonProperty("delay")]
        public string delay { get; set; }

        [JsonProperty("dateTime")]
        public string DateTime { get; set; }

        [JsonProperty("segmentIds")]
        public List<string> SegmentIds { get; set; }
    }
}
