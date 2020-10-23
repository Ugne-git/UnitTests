using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    [TestCategory("This a class category example")]
    public class Basics1
    {
        [TestMethod]
        [TestCategory("This is a method category example")]
        [Description("these are demo unit tests")]
        public void TestMethod1()
        {
            var a = 1;
            var b = 2;
            Assert.AreEqual(3, a + b);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var a = 1;
            Assert.IsTrue(a == 1);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var a = 2;
            Assert.AreNotEqual(1, a);
        }

        //test method with exception - test will pass if the exception is thrown
        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void TestMethod4()
        {
            var a = 1;
            Assert.AreNotEqual(1, a);
        }
    }
}
