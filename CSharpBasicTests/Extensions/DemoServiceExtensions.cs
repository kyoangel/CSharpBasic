using CSharpBasic.Services;

namespace CSharpBasicTests.Extensions
{
    internal static class DemoServiceExtensions
    {
        internal static int GetCarePlusDonCare(this DemoService service)
        {
            return service.Care + service.DonCare;
        }
    }
}