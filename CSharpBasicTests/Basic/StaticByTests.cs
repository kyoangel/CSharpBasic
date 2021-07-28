using CSharpBasic.Services;
using NUnit.Framework;

namespace CSharpBasicTests.Basic
{
    [TestFixture]
    public class StaticByTests
    {
        [Test]
        public void static_property_1()
        {
            DemoService.Property = "123";

            Assert.AreEqual("123",DemoService.Property);
        }


        [Test]
        public void static_property_2()
        {
            var demoService = new DemoService();

            Assert.AreEqual("123s",demoService.GetProperty());
        }

    }
}