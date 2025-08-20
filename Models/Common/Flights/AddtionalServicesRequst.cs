using AmadeusIntegration.Models.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmadeusIntegration.Models
{
    public class AdditionalServicesRequest
    {
        [JsonProperty("chargeableCheckedBags ")]
        public ChargeableCheckedBags ChargeableCheckedBags { get; set; }

        [JsonProperty("chargeableSeats")]
        public ChargeableSeat ChargeableSeats { get; set; }

        //Deprecated: Use chargeableSeats instead
        //public string chargeableSeatNumber { get; set; }
        public List<EServiceName> otherServices { get; set; }
    }
}
