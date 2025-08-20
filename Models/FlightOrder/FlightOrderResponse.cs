using Newtonsoft.Json;
using System.Collections.Generic;
using AmadeusIntegration.Models.Headers;
namespace AmadeusIntegration.Models
{
    public class FlightOrderResponse
    {

        [JsonProperty("meta")]
        public Meta Meta { get; set; }

        [JsonProperty("warnings")]
        public List<Issue> Warnings { get; set; }

        [JsonProperty("data")]
        public FlightOrderResponseData Data { get; set; }

        [JsonProperty("dictionaries")]
        public Dictionaries Dictionaries { get; set; }
    }

    public class FlightOrderResponseData
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("queuingOfficeId")]
        public string QueuingOfficeId { get; set; }

        [JsonProperty("ownerOfficeId")]
        public string OwnerOfficeId { get; set; }

        [JsonProperty("associatedRecords")]
        public List<AssociatedRecords> AssociatedRecords { get; set; }

        [JsonProperty("flightOffers")]
        public List<FlightOffer> FlightOffers { get; set; }

        [JsonProperty("travelers")]
        public List<TravelerElement> Travelers { get; set; }

        [JsonProperty("remarks")]
        public Remarks Remarks { get; set; }
        
        [JsonProperty("formOfPayment")]
        public List<FormOfPayment> FormOfPayments { get; set; }

        [JsonProperty("ticketingAgreement")]
        public TicketingAgreement TicketingAgreement { get; set; }

        [JsonProperty("automatedProcess")]
        public List<AutomatedProcess> AutomatedProcess { get; set; }

        [JsonProperty("contacts")]
        public List<Contact> Contacts { get; set; }

        [JsonProperty("tickets")]
        public List<AirTravelDocument>Tickets { get; set; }

        [JsonProperty("fromOfIdentification")]
        public List<FormOfIdentification> FormOfIdentifications { get; set; }



    }
}
