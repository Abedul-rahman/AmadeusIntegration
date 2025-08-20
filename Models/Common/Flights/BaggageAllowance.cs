using AmadeusIntegration.Models.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmadeusIntegration.Models
{
    public class BaggageAllowance
    {
        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("weight")]
        public int Weight { get; set; }

        [JsonProperty("weightUnit")]
        public EWeightUnits WeightUnit { get; set; }
    }
}
