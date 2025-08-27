using AmadeusIntegration.Http;
using AmadeusIntegration.Models;
using AmadeusIntegration.Models.Enums;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace AmadeusIntegration.Services
{
   
    public class FlightService:IFlightService
    {
        private readonly AmadeusHttpClient _client;

        public FlightService(AmadeusSettings settings)
        {
            _client = new AmadeusHttpClient(settings);
        }
        public  async Task<FlightSearchResponse> FindAllFlightsGet_Async(FlightSearchGetRequest request)
        {
            var endpoint = $"{_client.BaseUrl}/v2/shopping/flight-offers";
            var client = _client.CreateClient(endpoint);
            var restRequest = _client.CreateRequest(RestSharp.Method.Get);

            // Add params if they exist
            if (!string.IsNullOrEmpty(request.Origin))
                restRequest.AddParameter("originLocationCode", request.Origin);
            else throw new ArgumentException("Origin location code is required");

            if (!string.IsNullOrEmpty(request.Destination))
                restRequest.AddParameter("destinationLocationCode", request.Destination);
            else throw new ArgumentException("Destination location code is required");

            if (!string.IsNullOrEmpty(request.DepartureDate))
                restRequest.AddParameter("departureDate", request.DepartureDate);
            else throw new ArgumentException("Departure date is required");

            if (!string.IsNullOrEmpty(request.ReturnDate))
                restRequest.AddParameter("returnDate", request.ReturnDate);

            if(request.Adults<=0)
                throw new ArgumentException("Number of adults must be greater than 0");
            restRequest.AddParameter("adults", request.Adults);


            if (request.Children.HasValue)
                restRequest.AddParameter("children", request.Children.Value);

            if (request.Infants.HasValue)
                restRequest.AddParameter("infants", request.Infants.Value);

            if(request.TravelClass.HasValue)
                restRequest.AddParameter("travelClass",request.TravelClass.ToString());

            if (!string.IsNullOrEmpty(request.Currency))
                restRequest.AddParameter("currencyCode", request.Currency);

            if (request.Max.HasValue)
                restRequest.AddParameter("max", request.Max.Value);

            if (request.NonStop)
                restRequest.AddParameter("nonStop", request.NonStop.ToString().ToLower());

            if (!string.IsNullOrEmpty(request.MaxPrice))
            {
                restRequest.AddParameter("maxPrice", request.MaxPrice);

            }

            if (request.IncludedAirlineCodes != null)
                restRequest.AddParameter("includedAirlineCodes", string.Join(",", request.IncludedAirlineCodes));

            if (request.ExcludedAirlineCodes != null)
                restRequest.AddParameter("excludedAirlineCodes", string.Join(",", request.ExcludedAirlineCodes));
           


            var response = await client.ExecuteAsync(restRequest);

            if (!response.IsSuccessful)
                throw new Exception($"Amadeus API error: {response.Content}");

            return JsonConvert.DeserializeObject<FlightSearchResponse>(response.Content);
        }


        public  async Task<FlightPriceResponse> GetFlightPrice_Async(FlightPriceRequest request, List<EInclude> include = null, bool forceClass = false)
        {
        
            var endpoint = $"{_client.BaseUrl}/v1/shopping/flight-offers/pricing";
            var client = _client.CreateClient(endpoint);
            var restRequest = _client.CreateRequest(RestSharp.Method.Post);

            if (include != null)
                restRequest.AddParameter("include", string.Join(",", include.Select(i => i.ToString().Replace('_', '-'))));
            restRequest.AddJsonBody(request);
            if(forceClass)
            restRequest.AddParameter("forceClass", forceClass.ToString());
            var resp = await client.ExecuteAsync(restRequest);
            if (!resp.IsSuccessful) throw new Exception($"Price API error: {resp.Content}");
            return JsonConvert.DeserializeObject<FlightPriceResponse>(resp.Content);
        }
        public async Task<FlightOrderResponse> BookFlight_Async(FlightOrderRequest request)
        {
            var endpoint = $"{_client.BaseUrl}/v1/booking/flight-orders";
            var client = _client.CreateClient(endpoint);
            var restRequest = _client.CreateRequest(RestSharp.Method.Post);
            restRequest.AddJsonBody(request);
            var response = await client.ExecuteAsync(restRequest);
            if (!response.IsSuccessful)
                throw new Exception($"Booking API error: {response.Content}");

            
            return JsonConvert.DeserializeObject<FlightOrderResponse>(response.Content);
        }



    }
}
