using System;
using CSharpBasic.Services;
using ExpectedObjects;
using NUnit.Framework;

namespace CSharpBasicTests.Basic
{
    [TestFixture]
    public class StringByTests
    {
        [Test]
        public void string_by_example1()
        {
            string a = "1";
            string b = "1";

            Assert.IsTrue(a == b);
            Assert.IsTrue(a.Equals(b));
        }

        [Test]
        public void string_by_example2()
        {
            object a = "1";
            object b = "1";

            Assert.IsTrue(a == b);
            Assert.IsTrue(a.Equals(b));
        }


        [Test]
        public void class_by_example1()
        {
            var a = new DemoService();
            var b = new DemoService();

            // Assert.IsTrue(a == b);
            // Assert.IsTrue(a.Equals(b));
            // b.ToExpectedObject().ShouldEqual(a);
        }


        [Test]
        public void class_by_example2()
        {
            var a = new DemoService(){Care = 1, DonCare = 2};

            var b = new DemoService(){Care = 1};

            // Assert.IsTrue(a == b);
            // Assert.IsTrue(a.Equals(b));
            // b.ToExpectedObject().ShouldEqual(a);
        }


        [Test]
        public void object_by_example1()
        {
            object a = 1;
            object b = 1;

            // Assert.IsTrue(a == b);
        }

        [Test]
        public void object_by_example2()
        {
            object a = 1;
            object b = 1;

           // Assert.IsTrue(a.Equals(b));
        }
    }
}