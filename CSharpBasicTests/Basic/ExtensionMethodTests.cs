using CSharpBasic.Services;
using CSharpBasicTests.Extensions;
using NUnit.Framework;

namespace CSharpBasicTests.Basic
{
    [TestFixture]
    public class ExtensionMethodTests
    {
        [Test]
        public void ExtensionMethod()
        {
            var demoService = new DemoService
            {
                Care = 100,
                DonCare = 22
            };

            var actual = demoService.GetCarePlusDonCare();

            Assert.AreEqual(122, actual);
        }
    }
}