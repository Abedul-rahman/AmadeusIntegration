using Newtonsoft.Json;
using RestSharp;
using System;
using System.Text.Json.Serialization;

namespace AmadeusIntegration.Authentication
{
    internal class TokenManager
    {
        private readonly AmadeusSettings _settings;
        private string _accessToken;
        private DateTime _expiryTime;

        public TokenManager(AmadeusSettings settings)
        {
            _settings = settings;
        }

        public string baseUrl => _settings.BaseUrl;

        public string GetAccessToken()
        {
            if (string.IsNullOrEmpty(_accessToken) || DateTime.UtcNow >= _expiryTime)
            {
                RefreshToken();
            }
            return _accessToken;
        }
        public void RefreshToken()
        {
            var client = new RestClient($"{_settings.BaseUrl}/v1/security/oauth2/token");
            var request = new RestRequest { Method = Method.Post };
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("grant_type", "client_credentials");
            request.AddParameter("client_id", _settings.ClientId);
            request.AddParameter("client_secret", _settings.ClientSecret);

            var response = client.Execute(request);
            var token = JsonConvert.DeserializeObject<TokenResponse>(response.Content);

            _accessToken = token.access_token;
            _expiryTime = DateTime.UtcNow.AddSeconds(token.expires_in );




        }
    }
}
