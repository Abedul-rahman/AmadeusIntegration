using AmadeusIntegration.Models.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmadeusIntegration.Models
{
    public class Fee
    {
        [JsonProperty("amount")]
        public string Amount { get; set; }

        [JsonProperty("type")]
        public EFeeType Type { get; set; }
    }
}
