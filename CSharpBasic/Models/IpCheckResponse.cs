using System.Text.Json.Serialization;

namespace CSharpBasic.Models
{
    public class IpCheckResponse
    {
        [JsonPropertyName("country")]
        public string Country { get; set; }
        [JsonPropertyName("countryCode")]
        public string CountryCode { get; set; }
        [JsonPropertyName("query")]
        public string Query { get; set; }
    }
}