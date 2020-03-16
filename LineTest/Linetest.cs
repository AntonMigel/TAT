using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DEV_1._1;

namespace LineTest
{
    [TestClass]
    public class LineTest
    {
        [TestMethod]
        public void testGetNumberDiffSymbol()
        {
            int expected = 3;
            Line line = new Line("aba");
            Assert.AreEqual(line.getCountDiffSymbol(), expected);
        }
        [TestMethod]
        public void testNUllValue()
        {
            int expected =0;
            Line line = new Line(null);
            Assert.AreEqual(line.getCountDiffSymbol(), expected);
        }
        [TestMethod]
        public void testEmptyValue()    
        {
            int expected = 0;
            Line line = new Line(String.Empty);
            Assert.AreEqual(line.getCountDiffSymbol(), expected);
        }
    }
}