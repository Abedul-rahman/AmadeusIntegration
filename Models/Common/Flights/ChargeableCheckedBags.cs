using AmadeusIntegration.Models.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmadeusIntegration.Models
{
    public class ChargeableCheckedBags
    {
        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("weight")]
        public int Weight { get; set; }

        [JsonProperty("weightUnit")]
        public EWeightUnits WeightUnit { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

    }
}
