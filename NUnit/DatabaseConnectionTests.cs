using System;
using NUnit.Framework;

namespace Nunit_Assignment
{
    [TestFixture]
    public class DatabaseConnectionTests
    {
        private DatabaseConnection _dbConnection;

        [SetUp]
        public void Setup()
        {
            _dbConnection = new DatabaseConnection();
            _dbConnection.Connect();  // Setup before each test
        }

        [TearDown]
        public void Teardown()
        {
            _dbConnection.Disconnect();  // Cleanup after each test
        }

        [Test]
        public void Connect_WhenCalled_ShouldEstablishConnection()
        {
            Assert.IsTrue(_dbConnection.IsConnected, "Database should be connected after calling Connect().");
        }

        [Test]
        public void Disconnect_WhenCalled_ShouldCloseConnection()
        {
            _dbConnection.Disconnect();
            Assert.IsFalse(_dbConnection.IsConnected, "Database should be disconnected after calling Disconnect().");
        }
    }
}
