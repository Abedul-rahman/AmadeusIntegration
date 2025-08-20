using AmadeusIntegration.Authentication;
using AmadeusIntegration.Http;
using AmadeusIntegration.Models;
using AmadeusIntegration.Models.Enums;
using AmadeusIntegration.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmadeusIntegration.API
{
    public static class AmadeusFlightApi
    {
        private static IFlightService _flightService;
        private static bool _isInitialized = false;

        
        public static void Initialization(AmadeusSettings settings)
        {
            _flightService = new FlightService(settings);
            _isInitialized = true;
        }

       

        public static async Task<FlightSearchResponse> FindAllFlightsGet_Async(FlightSearchGetRequest request)
        {
            if (!_isInitialized)
                throw new InvalidOperationException("AmadeusFlightApi must be initialized before use.");

            return await _flightService.FindAllFlightsGet_Async(request);
        }
        public static async Task<FlightPriceResponse> GetFlightPrice_Async(FlightPriceRequest request, List<EInclude> include = null)
        {
            if (!_isInitialized)
                throw new InvalidOperationException("AmadeusFlightApi must be initialized before use.");
            return await _flightService.GetFlightPrice_Async(request, include);
        }
        public static async Task<FlightOrderResponse> BookFlight_Async(FlightOrderRequest request)
        {
            if (!_isInitialized)
                throw new InvalidOperationException("AmadeusFlightApi must be initialized before use.");
            return await _flightService.BookFlight_Async(request);
        }
    }

}
