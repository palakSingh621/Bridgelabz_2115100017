using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Nunit_Assignment
{
    [TestFixture]
    public class UserRegistrationTests
    {
        private UserRegistration _userRegistration;

        [SetUp]
        public void Setup()
        {
            _userRegistration = new UserRegistration();
        }

        [Test]
        public void RegisterUser_ShouldRegisterSuccessfully_WhenValidInput()
        {
            Assert.DoesNotThrow(() => _userRegistration.RegisterUser("JohnDoe", "john@example.com", "Password1"));
        }

        [Test]
        public void RegisterUser_ShouldThrowException_WhenUsernameIsEmpty()
        {
            Assert.Throws<ArgumentException>(() => _userRegistration.RegisterUser("", "john@example.com", "Password1"));
            Assert.Throws<ArgumentException>(() => _userRegistration.RegisterUser("   ", "john@example.com", "Password1"));
        }

        [Test]
        public void RegisterUser_ShouldThrowException_WhenEmailIsInvalid()
        {
            Assert.Throws<ArgumentException>(() => _userRegistration.RegisterUser("JohnDoe", "invalid-email", "Password1"));
            Assert.Throws<ArgumentException>(() => _userRegistration.RegisterUser("JohnDoe", "john@.com", "Password1"));
            Assert.Throws<ArgumentException>(() => _userRegistration.RegisterUser("JohnDoe", "john@example", "Password1"));
        }

        [Test]
        public void RegisterUser_ShouldThrowException_WhenPasswordIsWeak()
        {
            Assert.Throws<ArgumentException>(() => _userRegistration.RegisterUser("JohnDoe", "john@example.com", "pass")); // Too short
            Assert.Throws<ArgumentException>(() => _userRegistration.RegisterUser("JohnDoe", "john@example.com", "password")); // No uppercase, no digit
            Assert.Throws<ArgumentException>(() => _userRegistration.RegisterUser("JohnDoe", "john@example.com", "PASSWORD1")); // No lowercase
            Assert.Throws<ArgumentException>(() => _userRegistration.RegisterUser("JohnDoe", "john@example.com", "Password")); // No digit
        }
    }
}
