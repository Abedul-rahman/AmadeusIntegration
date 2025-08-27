using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;

public static class JsonConfig
{
    public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
    {
        NullValueHandling = NullValueHandling.Ignore, 
        ContractResolver = new CamelCasePropertyNamesContractResolver(),
        Converters = new List<JsonConverter>
        {
            new StringEnumConverter() ,

            new IsoDateTimeConverter { DateTimeFormat ="yyyy-MM-ddTHH:mm:ss" } 
        }
    };
}
