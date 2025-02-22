using System;
using Nunit_Assignment;
using NUnit.Framework;
namespace NUnit_Tests
{
    [TestFixture]
    public class StringUtilsTests
    {
        private StringUtils _stringUtils;

        [SetUp]
        public void Setup()
        {
            _stringUtils = new StringUtils();
        }

        [Test]
        public void Reverse_WhenCalled_ReturnsReversedString()
        {
            string result = _stringUtils.Reverse("hello");
            Assert.AreEqual("olleh", result);
        }

        [Test]
        public void Reverse_WhenEmptyString_ReturnsEmptyString()
        {
            string result = _stringUtils.Reverse("");
            Assert.AreEqual("", result);
        }

        [Test]
        public void Reverse_WhenNull_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => _stringUtils.Reverse(null));
        }

        [Test]
        public void IsPalindrome_WhenPalindrome_ReturnsTrue()
        {
            bool result = _stringUtils.IsPalindrome("madam");
            Assert.IsTrue(result);
        }

        [Test]
        public void IsPalindrome_WhenNotPalindrome_ReturnsFalse()
        {
            bool result = _stringUtils.IsPalindrome("hello");
            Assert.IsFalse(result);
        }

        [Test]
        public void IsPalindrome_WhenNull_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => _stringUtils.IsPalindrome(null));
        }

        [Test]
        public void ToUpperCase_WhenCalled_ReturnsUpperCaseString()
        {
            string result = _stringUtils.ToUpperCase("hello");
            Assert.AreEqual("HELLO", result);
        }

        [Test]
        public void ToUpperCase_WhenEmptyString_ReturnsEmptyString()
        {
            string result = _stringUtils.ToUpperCase("");
            Assert.AreEqual("", result);
        }

        [Test]
        public void ToUpperCase_WhenNull_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => _stringUtils.ToUpperCase(null));
        }
    }
}
}
