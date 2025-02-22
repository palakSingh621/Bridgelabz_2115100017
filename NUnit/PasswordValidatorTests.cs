using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Nunit_Assignment
{
    [TestFixture]
    public class PasswordValidatorTests
    {
        private PasswordValidator _validator;

        [SetUp]
        public void Setup()
        {
            _validator = new PasswordValidator();
        }

        [Test]
        public void Password_ShouldBeValid_WhenItMeetsCriteria()
        {
            Assert.IsTrue(_validator.IsValidPassword("StrongP@ss1"));
        }

        [Test]
        public void Password_ShouldBeInvalid_WhenTooShort()
        {
            Assert.IsFalse(_validator.IsValidPassword("Short1"));
        }

        [Test]
        public void Password_ShouldBeInvalid_WhenNoUppercaseLetter()
        {
            Assert.IsFalse(_validator.IsValidPassword("password123"));
        }

        [Test]
        public void Password_ShouldBeInvalid_WhenNoDigit()
        {
            Assert.IsFalse(_validator.IsValidPassword("PasswordOnly"));
        }

        [Test]
        public void Password_ShouldBeValid_WithMinimumValidCriteria()
        {
            Assert.IsTrue(_validator.IsValidPassword("Apassw0rd"));
        }
    }
}
