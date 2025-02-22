using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Nunit_Assignment
{
    [TestFixture]
    public class TemperatureConverterTests
    {
        private TemperatureConverter _converter;

        [SetUp]
        public void Setup()
        {
            _converter = new TemperatureConverter();
        }

        [Test]
        public void CelsiusToFahrenheit_ShouldConvertCorrectly()
        {
            Assert.AreEqual(32, _converter.CelsiusToFahrenheit(0), 0.001);
            Assert.AreEqual(212, _converter.CelsiusToFahrenheit(100), 0.001);
            Assert.AreEqual(98.6, _converter.CelsiusToFahrenheit(37), 0.001);
        }

        [Test]
        public void FahrenheitToCelsius_ShouldConvertCorrectly()
        {
            Assert.AreEqual(0, _converter.FahrenheitToCelsius(32), 0.001);
            Assert.AreEqual(100, _converter.FahrenheitToCelsius(212), 0.001);
            Assert.AreEqual(37, _converter.FahrenheitToCelsius(98.6), 0.001);
        }

        [Test]
        public void CelsiusToFahrenheit_ShouldHandleNegativeValues()
        {
            Assert.AreEqual(-40, _converter.CelsiusToFahrenheit(-40), 0.001);
        }

        [Test]
        public void FahrenheitToCelsius_ShouldHandleNegativeValues()
        {
            Assert.AreEqual(-40, _converter.FahrenheitToCelsius(-40), 0.001);
        }
    }
}
