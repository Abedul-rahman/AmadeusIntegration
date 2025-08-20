using AmadeusIntegration.Models.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
namespace AmadeusIntegration.Models
{
    public class FlightOffer
    {
        [JsonProperty("type")]
        [JsonRequired]
        public string Type { get; set; }

        [JsonProperty("id")]
        [JsonRequired]
        public string Id { get; set; }

        [JsonProperty("source")]
        public EFlightOfferSource Source { get; set; }

        [JsonProperty("instantTicketingRequired")]
        public bool InstantTicketingRequired { get; set; }

        [JsonProperty("disablePricing")]
        public bool DisablePricing { get; set; }

        [JsonProperty("nonHomogeneous")]
        public bool NonHomogeneous { get; set; }

        [JsonProperty("oneWay")]
        public bool OneWay { get; set; }

        [JsonProperty("paymentCardRequired")]
        public bool PaymentCardRequired { get; set; }

        [JsonProperty("lastTicketingDate")]
        public string LastTicketingDate { get; set; }

        [JsonProperty("lastTicketingDateTime")]
        public DateTime LastTicketingDateTime { get; set; }


        [JsonProperty("numberOfBookableSeats")]
        public int NumberOfBookableSeats { get; set; }

        [JsonProperty("itineraries")]
        public List<Itinerary> Itineraries { get; set; }

        [JsonProperty("price")]
        public Price Price { get; set; }

        [JsonProperty("pricingOptions")]
        public PricingOptions PricingOptions { get; set; }

        [JsonProperty("validatingAirlineCodes")]
        public List<string> ValidatingAirlineCodes { get; set; }

        [JsonProperty("travelerPricings")]
        public List<TravelerPricing> TravelerPricings { get; set; }
    }
}
