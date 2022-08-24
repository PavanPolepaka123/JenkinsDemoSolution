using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using JenkinsDemo;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Program p = new Program();
            int ac = p.Add(1, 2);
            Assert.AreEqual(3, ac);
        }
    }
}
