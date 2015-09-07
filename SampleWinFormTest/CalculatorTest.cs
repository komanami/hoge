using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleWinForm;

namespace SampleWinFormTest
{
    [TestClass]
    public class CalculatorTest
    {
        private Calculator calculator = new Calculator();

        [TestMethod]
        public void 和_1足す2は3であるべき()
        {
            Assert.AreEqual(3, this.calculator.Add(1, 2));
        }

        [TestMethod]
        public void 差_5引く2は3であるべき()
        {
            Assert.AreEqual(3, this.calculator.Subtract(5, 2));
        }

        [TestMethod]
        public void 積_3掛ける3は9であるべき()
        {
            Assert.AreEqual(9, this.calculator.Multiply(3, 3));
        }

        [TestMethod]
        public void 商_6割る2は3であるべき()
        {
            Assert.AreEqual(3, this.calculator.Divide(6, 2));
        }
    }
}