using System.Net;
using System.Threading.Tasks;
using CSharpBasic.Models;

namespace CSharpBasic.Services
{
    public interface IIpIFyProxy
    {
        Task<IpCheckResponse> IpCheckAsync(IPAddress ip);
        Task<IPAddress> GetCurrentIpAsync();
    }
}
