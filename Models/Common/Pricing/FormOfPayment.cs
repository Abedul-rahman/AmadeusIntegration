using Newtonsoft.Json;
using System.Collections.Generic;
using AmadeusIntegration.Models.Enums;
namespace AmadeusIntegration.Models
{
    public class FormOfPayment
    {
        [JsonProperty("b2bWallet")]
        public B2bWallet b2bWallet { get; set; }

        [JsonProperty("creditCard")]
        public CreditCard creditCard { get; set; }

        [JsonProperty("other")]
        public OtherCreditCard other { get; set; }
    }


   
}
