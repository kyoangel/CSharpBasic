using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using CSharpBasic.Interfaces;
using CSharpBasic.Models;
using Microsoft.Extensions.Logging;

namespace CSharpBasic.Services
{
    public class WhereAmIService : IWhereAmIService
    {
        private readonly HttpClient _client;

        public WhereAmIService()
        {
            _client = HttpClientFactory.Create();
        }

        public async Task<WhereAmIGetIpResponse> GetIp()
        {
            var response = new HttpResponseMessage();
            try
            {
                response = await _client.GetAsync("https://api.ipify.org?format=json");
                return await response.Content.ReadAsAsync<WhereAmIGetIpResponse>();
            }
            catch (Exception e)
            {
                throw new Exception($"Status Code: {response.StatusCode}, Error message: {e}");
            }
        }

        public async Task<List<IpDetail>> GetIpDetail(List<string> ipList)
        {
            var response = new HttpResponseMessage();
            try
            {
                response = await _client.PostAsJsonAsync("http://ip-api.com/batch", ipList);
                return await response.Content.ReadAsAsync<List<IpDetail>>();
            }
            catch (Exception e)
            {
                throw new Exception($"Status Code: {response.StatusCode}, Error message: {e}");
            }
        }
    }
}