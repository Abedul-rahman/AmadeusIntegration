using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Sockets;
using System.Web.Security;
using System.Web.UI.WebControls;
namespace AmadeusIntegration.Models
{
    public class FlightOrderRequest
    {
        [JsonProperty("data")]
        public FlightOrderRequestData Data { get; set; }

    }   


    public class FlightOrderRequestData
    {
        [JsonProperty("type")]
        [JsonRequired]
        public string Type { get; set; } = "flight-order";
        /// <summary>
        /// What it is: The office ID (IATA PCC / Office ID) where the PNR will be queued after booking.
        /// Why: Some agencies want to queue PNRs to a back-office team for ticketing or quality check.
        /// How to fill: Only if your workflow requires manual queueing to another office. Otherwise, leave null.
        ///👉 If you’re a normal API consumer without special IATA office flows, you don’t need it.
        /// </summary>
        [JsonProperty("queuingOfficeId")]
        public string QueuingOfficeId { get; set; }


        /// <summary>
        /// What it is: Office ID that will be recorded as the owner of the PNR.
        ///Why: In multi-office agency setups, ownership matters for who can modify/cancel.
        ///How to fill: Usually only relevant for Travel Agencies with multiple PCCs.
        ///If you’re not an accredited IATA agency → skip it.
        /// </summary>
        [JsonProperty("ownerOfficeId")]
        public string OwnerOfficeId { get; set; }

        [JsonRequired]
        [JsonProperty("flightOffers")]
        public List<FlightOffer> FlightOffers { get; set; }

            
        [JsonProperty("travelers")]
        public List<TravelerElement> Travelers { get; set; }


        /// <summary>
        /// What it is: Free-text remarks you want to add to the booking (e.g., “VIP passenger”, “Handle with care”).
       /// Why: Often used for agency internal communication or airline notes.
        /// </summary>
        [JsonProperty("remarks")]
        public Remarks Reamarks { get; set; }

        /// <summary>
        /// What it is: Defines when tickets should be issued for this booking.
        ///Why: Amadeus separates "Booking" (PNR creation) and "Ticketing" (payment + ticket number issuance).
        /// </summary>
        [JsonProperty("ticketingAgreement")]
        public TicketingAgreement TicketingAgreement { get; set; }


        /// <summary>
        /// What it is: Instructions for Amadeus automation services (e.g., auto-cancel, auto-queue).
        ///Why: Advanced agency workflows.
        /// </summary>
        [JsonProperty("automatedProcess")]
        public List<AutomatedProcess> AutomatedProcess { get; set; }


        [JsonProperty("contacts")]
        public List<Contact> Contacts { get; set; }

        /// <summary>
        /// What it is: Frequent Flyer numbers, loyalty programs, ID numbers.
        ///Why: To add frequent flyer programs or other IDs to the PNR.
        /// </summary>


                [JsonProperty("formOfIdentifications")]
        public List<FormOfIdentification> FormOfIdentifications { get; set; }


        
    }

}
