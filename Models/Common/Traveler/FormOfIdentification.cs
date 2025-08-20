using AmadeusIntegration.Models.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmadeusIntegration.Models
{
    public class FormOfIdentification
    {
        [JsonProperty("identificationType")]
        public EIdentificationType IdentificationType { get; set; }

        [JsonProperty("carrierCode")]
        public string CarrierCode { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("travelerIds")]
        public List<string> TravelerIds { get; set; }

        [JsonProperty("flightOderId")]
        public List<string> FlightOrderId { get; set; }

    }
}
