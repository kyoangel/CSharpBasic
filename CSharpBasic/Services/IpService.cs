using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using CSharpBasic.Interfaces;
using CSharpBasic.Models;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace CSharpBasic.Services
{
	public class IpService : IIpService
	{
		private readonly IHttpClientFactory _clientFactory;
		private readonly ILogger<IpService> _logger;

		public IpService(IHttpClientFactory clientFactory, ILogger<IpService> logger)
		{
			_clientFactory = clientFactory;
			_logger = logger;
		}

		public GetIpResponse GetIpData()
		{
			var ip = GetCurrentIp();
			var countryCode = GetIpDetail(ip).CountryCode;
			return new GetIpResponse()
			{
				Ip = ip,
				CountryCode = countryCode
			};
		}

		private IpDetail GetIpDetail(string ip)
		{
			var client = _clientFactory.CreateClient();
			var ips = new[]{ ip} ;
			var stringContent = JsonConvert.SerializeObject(ips);
			try
			{
				var response = client.PostAsync("http://ip-api.com/batch", new StringContent(stringContent)).Result;
				var ipDetail = JsonConvert.DeserializeObject<List<IpDetail>>(response.Content.ReadAsStringAsync().Result).FirstOrDefault();
				return ipDetail;
			}
			catch (Exception ex)
			{
				_logger.LogInformation($"Get Ip Detail Fail: {ex} , request ip {ip}");
				throw;
			}
		}

		private string GetCurrentIp()
		{
			var client = _clientFactory.CreateClient();
			try
			{
				var response = client.GetStringAsync("https://api.ipify.org?format=json").Result;
				var result = JsonConvert.DeserializeObject<CurrentIp>(response);
				return result.Ip;
			}
			catch (Exception ex)
			{
				_logger.LogInformation($"Get Current Ip Fail: {ex}");
				throw;
			}
		}
	}
}