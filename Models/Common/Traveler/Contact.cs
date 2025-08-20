using AmadeusIntegration.Models.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmadeusIntegration.Models
{
    public class Contact
    {
        [JsonProperty("addresseeName")]
        public Name AddresseeName { get; set; }

        [JsonProperty("adress")]
        public Adress Adress { get; set; }

        [JsonProperty("language")]
        public string language { get; set; }


        [JsonProperty("purpose")]
        public EContactPurpose Purpose { get; set; }

        [JsonProperty("phones")]
        public List<Phone> Phones { get; set; }

        [JsonProperty("companyName")]
        public string CompanyName { get; set; }

        [JsonProperty("emailAddress")]
        public string EmailAddress { get; set; }
    }
    public class Phone
    {
        [JsonProperty("deviceType")]
        public EPhoneDeviceType DeviceType { get; set; } // e.g. "MOBILE"

        [JsonProperty("countryCallingCode")]
        public string CountryCallingCode { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }
    }
}
