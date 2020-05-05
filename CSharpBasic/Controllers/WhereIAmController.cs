using System;
using System.Threading.Tasks;
using CSharpBasic.Interfaces;
using CSharpBasic.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CSharpBasic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WhereIAmController : ControllerBase
    {
	    private readonly IIpService _ipService;
	    public WhereIAmController(IIpService ipService)
	    {
		    _ipService = ipService;
	    }
        // GET: api/WhereIAm
        [HttpGet]
        public GetIpResponse Index()
        {
            return _ipService.GetIpData();
        }


    }
}
