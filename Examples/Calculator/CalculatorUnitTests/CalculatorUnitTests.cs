using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCalculator;
using System;

namespace CalculatorUnitTests
{
    [TestClass]
    public class CalculatorUnitTests
    {
        [TestMethod]
        public void Add_ValidNumbers()
        {
            var target = new Calculator();
            var ret = target.Add(1, 2);

            Assert.AreEqual(3, ret);
        }

        [TestMethod]
        public void Subtract_ValidNumbers()
        {
            var target = new Calculator();
            var ret = target.Subtract(2, 1);

            Assert.AreEqual(1, ret);
        }
        [TestMethod]
        public void Multiply_ValidNumbers()
        {
            var target = new Calculator();
            var ret = target.Multiply(2, 4);

            Assert.AreEqual(8, ret);
        }
        [TestMethod]
        public void Divide_ValidNumbers()
        {
            var target = new Calculator();
            var ret = target.Divide(20, 2);

            Assert.AreEqual(10, ret);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Divide_ByZero()
        {
            var target = new Calculator();
            var ret = target.Divide(20, 0);

            Assert.AreEqual(0, ret);
        }

        [TestMethod]
        public void GetHypo()
        {
            var target = new Calculator();
            var ret = target.Pythagorus(3, 4);

            Assert.AreEqual(5, ret);
        }
    }
}
