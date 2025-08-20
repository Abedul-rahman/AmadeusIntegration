using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmadeusIntegration.Models
{
    public class LoyaltyProgram
    {
        [JsonProperty("programOwner")]
        public string ProgramOwner { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }
}
