using AmadeusIntegration.Models.Enums;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AmadeusIntegration.Models
{
   

    public class TravelerDocument
    {
        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("issuanceDate")]
        public string IssuanceDate { get; set; }

        [JsonProperty("expiryDate")]
        public string ExpiryDate { get; set; }

        /// <summary>
        /// ISO 3166-1 alpha-2 of the country that issued the document
        /// </summary>

        [JsonProperty("issuanceCountry")]
        public string IssuanceCountry { get; set; }

        [JsonProperty("issuanceLocation")]
        public string IssuanceLocation { get; set; }

        [JsonProperty("nationality")]
        public string Nationality { get; set; }

        [JsonProperty("birthPlace")]
        public string BirthPlace { get; set; }

        [JsonProperty("documentType")]
        public EDocumentType DocumentType { get; set; }
       
        [JsonProperty("validityCountry")]
        public string ValidityCountry { get; set; }

        [JsonProperty("birthCountry")]
        public string BirthCountry { get; set; }

        [JsonProperty("holder")]
        public bool Holder { get; set; }

    }

}
