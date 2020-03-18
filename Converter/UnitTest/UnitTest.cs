using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Converter;

namespace UnitTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void Test1ConvertVariousSystem()
        {
            string expected = "1010";
            string actual=Converter.сonvertFromDec.ConvertVariousSystem("10", "2");
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void Test2ConvertVariousSystem()
        {
            string expected = "ABC";
            Assert.AreEqual(Converter.сonvertFromDec.ConvertVariousSystem("2748", "16"), expected);
        }
        [TestMethod]
        public void Test3ConvertVariousSystem()
        {
            string expected = "256";
            Assert.AreEqual(Converter.сonvertFromDec.ConvertVariousSystem("174", "8"), expected);
        }
    }
    }


