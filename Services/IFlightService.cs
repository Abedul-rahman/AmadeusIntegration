using AmadeusIntegration.Models;
using AmadeusIntegration.Models.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace AmadeusIntegration.Services

{
    // Services/IFlightService.cs
    public interface IFlightService
    {
        Task<FlightSearchResponse> FindAllFlightsGet_Async(FlightSearchGetRequest request);
        Task<FlightPriceResponse> GetFlightPrice_Async(FlightPriceRequest request,List<EInclude> include,bool forceClass=false);

        Task<FlightOrderResponse> BookFlight_Async(FlightOrderRequest request);
   
    }

}
