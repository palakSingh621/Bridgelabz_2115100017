using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Nunit_Assignment
{
    [TestFixture]
    public class DateFormatterTests
    {
        private DateFormatter _formatter;

        [SetUp]
        public void Setup()
        {
            _formatter = new DateFormatter();
        }

        [Test]
        public void FormatDate_ShouldConvertValidDate()
        {
            Assert.AreEqual("25-12-2023", _formatter.FormatDate("2023-12-25"));
            Assert.AreEqual("01-01-2000", _formatter.FormatDate("2000-01-01"));
        }

        [Test]
        public void FormatDate_ShouldThrowExceptionForInvalidFormat()
        {
            Assert.Throws<FormatException>(() => _formatter.FormatDate("12-25-2023"));
            Assert.Throws<FormatException>(() => _formatter.FormatDate("25/12/2023"));
            Assert.Throws<FormatException>(() => _formatter.FormatDate("2023/12/25"));
            Assert.Throws<FormatException>(() => _formatter.FormatDate("abcd-ef-gh"));
        }

        [Test]
        public void FormatDate_ShouldThrowExceptionForEmptyOrNullInput()
        {
            Assert.Throws<FormatException>(() => _formatter.FormatDate(""));
            Assert.Throws<FormatException>(() => _formatter.FormatDate(null));
        }
    }
}
