using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Antipina_OlnineStickerStore;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            bool expect = true;
            bool result = MainWindow.Test("***");
            Assert.AreEqual(expect, result);
        }
    }
}

