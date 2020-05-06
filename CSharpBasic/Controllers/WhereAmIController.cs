using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using CSharpBasic.Interfaces;
using CSharpBasic.Models;
using Microsoft.AspNetCore.Mvc;

namespace CSharpBasic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WhereAmIController : ControllerBase
    {
        private readonly HttpClient _client;
        private readonly IWhereAmIService _whereAmIService;

        public WhereAmIController(IWhereAmIService whereAmiIService)
        {
            _client = HttpClientFactory.Create();
            _whereAmIService = whereAmiIService;
        }

        [HttpGet]
        public async Task<ActionResult<WhereAmIResponse>> Index()
        {
            var response = await _whereAmIService.GetIp();
            var request = new List<string>() {response.Ip};
            var detail = await _whereAmIService.GetIpDetail(request);
            return Ok(new WhereAmIResponse
            {
                Ip = detail[0].Query,
                CountryCode = detail[0].CountryCode
            });
        }
    }
}