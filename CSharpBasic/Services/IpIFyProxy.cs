using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using CSharpBasic.Models;

namespace CSharpBasic.Services
{
    class IpIFyProxy : IIpIFyProxy
    {
        private readonly HttpClient _httpClient;

        public IpIFyProxy(IHttpClientFactory httpFactory)
        {
            _httpClient = httpFactory.CreateClient("IpProxy");
        }

        public async Task<IpCheckResponse> IpCheckAsync(string ip)
        {
            var response = await _httpClient.PostAsync("batch", new StringContent($"[\"{ip}\"]"));

            var responseStatusCode = response.StatusCode;
            var readAsStringAsync = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<List<IpCheckResponse>>(readAsStringAsync).First();
        }
    }
}