using System.Collections.Generic;
using System.Threading.Tasks;
using CSharpBasic.Models;

namespace CSharpBasic.Interfaces
{
    public interface IWhereAmIService
    {
        Task<WhereAmIGetIpResponse> GetIp();
        Task<List<IpDetail>> GetIpDetail(List<string> ipList);
    }
}