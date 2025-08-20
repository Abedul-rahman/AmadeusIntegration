using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmadeusIntegration.Models
{
    public class Operating
    {
        [JsonProperty("carrierCode")]
        public string CarrierCode { get; set; }
    }
}
