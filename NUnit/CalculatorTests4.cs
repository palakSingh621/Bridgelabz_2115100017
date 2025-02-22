using System;
using NUnit.Framework;

namespace Nunit_Assignment
{
    [TestFixture]
    public class CalculatorTests4
    {
        private Calculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        [Test]
        public void Divide_WhenDividingByZero_ThrowsArithmeticException()
        {
            // Assert that calling Divide with 0 as the denominator throws an exception
            Assert.Throws<ArithmeticException>(() => _calculator.Divide(10, 0));
        }

        [Test]
        public void Divide_WithValidNumbers_ReturnsCorrectResult()
        {
            int result = _calculator.Divide(10, 2);
            Assert.AreEqual(5, result);
        }
    }
}
