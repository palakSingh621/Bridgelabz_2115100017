using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Nunit_Assignment
{
    [TestFixture]
    public class BankAccountTests
    {
        private BankAccount _account;

        [SetUp]
        public void Setup()
        {
            _account = new BankAccount(100); // Start with $100
        }

        [Test]
        public void Deposit_ShouldIncreaseBalance()
        {
            _account.Deposit(50);
            Assert.AreEqual(150, _account.GetBalance());
        }

        [Test]
        public void Withdraw_ShouldDecreaseBalance()
        {
            _account.Withdraw(30);
            Assert.AreEqual(70, _account.GetBalance());
        }

        [Test]
        public void Withdraw_ShouldThrowException_WhenFundsAreInsufficient()
        {
            var ex = Assert.Throws<InvalidOperationException>(() => _account.Withdraw(200));
            Assert.AreEqual("Insufficient funds.", ex.Message);
        }

        [Test]
        public void Deposit_ShouldThrowException_WhenAmountIsNegative()
        {
            var ex = Assert.Throws<ArgumentException>(() => _account.Deposit(-10));
            Assert.AreEqual("Deposit amount must be positive.", ex.Message);
        }

        [Test]
        public void Withdraw_ShouldThrowException_WhenAmountIsNegative()
        {
            var ex = Assert.Throws<ArgumentException>(() => _account.Withdraw(-20));
            Assert.AreEqual("Withdrawal amount must be positive.", ex.Message);
        }

        [Test]
        public void InitialBalance_ShouldThrowException_WhenNegative()
        {
            var ex = Assert.Throws<ArgumentException>(() => new BankAccount(-50));
            Assert.AreEqual("Initial balance cannot be negative.", ex.Message);
        }
    }
}
