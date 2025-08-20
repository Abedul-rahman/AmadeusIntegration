// Http/AmadeusHttpClient.cs
using AmadeusIntegration.Authentication;
using RestSharp;
using RestSharp.Serializers.NewtonsoftJson;

namespace AmadeusIntegration.Http

{
    internal class AmadeusHttpClient
    {
        private readonly TokenManager _tokenManager;

        public string BaseUrl=> _tokenManager.baseUrl;

        public AmadeusHttpClient(TokenManager tokenManager)
        {
            _tokenManager = tokenManager;
        }
        public AmadeusHttpClient(AmadeusSettings settings)
        {
            _tokenManager = new TokenManager(settings);
        }
        public RestClient CreateClient(string endpoint)
        {
            var client = new RestClient(
                endpoint,
                configureSerialization:s=>s.UseNewtonsoftJson(JsonConfig.Settings)
                );
            return client;
        }

        public RestRequest CreateRequest(Method method)
        {
            
            var request = new RestRequest{Method=method};
            
            
            request.AddHeader("Authorization", $"Bearer {_tokenManager.GetAccessToken()}");
            return request;
        }
    }
}

