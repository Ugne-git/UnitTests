using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestPractice
{
    [TestClass]
    [TestCategory("Quiz")]
    public class Basics2
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(2, 1 + 1);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.Fail("This test will always fail");
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void TestMethod3()
        {
            Assert.AreEqual(21, 10 + 10);
        }
    }
}
