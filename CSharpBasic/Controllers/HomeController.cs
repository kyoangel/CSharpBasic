using System.Diagnostics;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CSharpBasic.Models;
using CSharpBasic.Services;

namespace CSharpBasic.Controllers
{
    [ApiController]
    [Route("api")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IIpIFyProxy _ipiFyProxy;

        public HomeController(ILogger<HomeController> logger, IIpIFyProxy ipiFyProxy)
        {
            _logger = logger;
            _ipiFyProxy = ipiFyProxy;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet("WhereAmI")]
        public async Task<ActionResult<CheckIpResponse>> CheckIp()
        {
            var ip = await _ipiFyProxy.GetCurrentIpAsync();

            var ipCheckResponse = await _ipiFyProxy.IpCheckAsync(ip);

            _logger.LogInformation($"CheckIpAPI :::ipCheckResponse:{JsonSerializer.Serialize(ipCheckResponse)}");
            
            return new CheckIpResponse()
            {
                Ip = ipCheckResponse.Query,
                CountryCode = ipCheckResponse.CountryCode,
            };
        }
    }
}
