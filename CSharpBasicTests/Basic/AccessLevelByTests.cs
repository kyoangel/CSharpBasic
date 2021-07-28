using CSharpBasic.Services;
using NUnit.Framework;

namespace CSharpBasicTests.Basic
{
    [TestFixture]
    public class AccessLevelByTests
    {
        [Test]
        public void access_level_public()
        {
            var demoService = new DemoService();

            var actual = demoService.PublicMethod();

            Assert.AreEqual("result", actual);
        }

        [Test]
        public void access_level_internal()
        {
            // var demoService = new DemoService();

            // var actual = demoService.InternalMethod();

            // Assert.AreEqual("result",actual);
        }

        [Test]
        public void access_level_protected()
        {
            // var demoService = new DemoService();

            // var actual = demoService.InternalMethod();

            // Assert.AreEqual("result",actual);
        }

        [Test]
        public void access_level_private()
        {
            // var demoService = new DemoService();

            // var actual = demoService.InternalMethod();

            // Assert.AreEqual("result",actual);
        }
    }
}