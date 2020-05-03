using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using CSharpBasic.Services;
using Microsoft.AspNetCore.DataProtection.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CSharpBasic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WhereAmIController : ControllerBase
    {
        private readonly HttpClient _client;
        private WhereAmIService _WhereAmIService;

        public WhereAmIController()
        {
            _client = HttpClientFactory.Create();
            _WhereAmIService = new WhereAmIService();
        }

        [HttpGet]
        public async Task<string> Index()
        {
            var response = await _WhereAmIService.GetIp();
            var request = PrepareGetDetail(response.Ip);
            var detail = await _WhereAmIService.GetIpDetail(request);
            return $"Ip: {detail[0].Query}, Country Code: {detail[0].CountryCode}";
        }

        public List<string> PrepareGetDetail(string ip)
        {
            return new List<string>() {ip};
        }
    }
}