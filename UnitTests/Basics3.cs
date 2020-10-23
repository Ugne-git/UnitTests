using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestPractice2
{
    [TestClass]
    [TestCategory("Practice")]
    public class Basics3
    {
        private int a; // a class level variable (available to the whole class

        [ClassInitialize]
        public static void RunBeforeAllTests(TestContext testContext)
        {
            Trace.Write("RunBeforeAllTests method will execute beore all the tests in the class started");
        }

        [TestInitialize]
        public void RunBeforeEveryTest()
        {
            a = 1;
        }

        [TestMethod]
        public void TestMethod1()
        {
            var b = 2;
            Assert.AreEqual(3, a + b);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.IsTrue(a == 1);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void TestMethod3()
        {
            Assert.AreNotEqual(1, a);
        }

        [TestCleanup]
        public void RunAfterEveryTest()
        {
            Trace.Write("RunAfterEveryTest method will execute after every single method in a class");
        }

        [ClassCleanup]
        public static void RunAfterAllTests()
        {
            Trace.Write("RunAfterAllTests method will execute after all tests in a class executed");
        }
    }
}
