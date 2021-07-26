using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using CSharpBasic.Models;

namespace CSharpBasic.Services
{
    class IpIFyProxy : IIpIFyProxy
    {
        private readonly HttpClient _comHttpClient;
        private readonly HttpClient _orgHttpClient;

        public IpIFyProxy(IHttpClientFactory httpFactory)
        {
            _comHttpClient = httpFactory.CreateClient("IpIfy.COM");
            _orgHttpClient = httpFactory.CreateClient("Ipify.ORG");
        }

        public async Task<IpCheckResponse> IpCheckAsync(IPAddress ip)
        {
            var response = await _comHttpClient.PostAsync("batch", new StringContent($"[\"{ip}\"]"));

            return JsonSerializer.Deserialize<List<IpCheckResponse>>(await response.Content.ReadAsStringAsync()).First();
        }

        public async Task<IPAddress> GetCurrentIpAsync()
        {
            var response = await _orgHttpClient.GetAsync("?format=json");

            var ipAddress = JsonSerializer.Deserialize<CurrentIpAddressResponse>(
                await response.Content.ReadAsStringAsync());

            return IPAddress.Parse(ipAddress.Ip);
        }
    }

    public class CurrentIpAddressResponse
    {
        [JsonPropertyName("ip")]
        public string Ip { get; set; }
    }
}
