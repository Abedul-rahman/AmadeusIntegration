using AmadeusIntegration.Models.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmadeusIntegration.Models
{
    public  class AutomatedProcess
    {
        [JsonProperty("code")]
        public EAutomatedProcessCode Code { get; set; }

        [JsonProperty("queue")]
        public Queue Queue { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("delay")]
        public string Delay { get; set; }

        [JsonProperty("officeId")]
        public string OfficeId { get; set; } 

        [JsonProperty("dateTime")]
        public DateTime DateTime { get; set; }

    }
    public struct Queue
    {
        [JsonProperty("number")]
        public string number { get; set; }


        [JsonProperty("category")]
        public string category { get; set; }
    }
}
