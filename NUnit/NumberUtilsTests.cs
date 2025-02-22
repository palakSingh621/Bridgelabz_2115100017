using System;
using NUnit.Framework;
namespace Nunit_Assignment
{
    [TestFixture]
    public class NumberUtilsTests
    {
        private NumberUtils _numberUtils;

        [SetUp]
        public void Setup()
        {
            _numberUtils = new NumberUtils();
        }

        [TestCase(2, true)]
        [TestCase(4, true)]
        [TestCase(6, true)]
        [TestCase(7, false)]
        [TestCase(9, false)]
        public void IsEven_WhenCalled_ReturnsCorrectResult(int number, bool expectedResult)
        {
            bool result = _numberUtils.IsEven(number);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
