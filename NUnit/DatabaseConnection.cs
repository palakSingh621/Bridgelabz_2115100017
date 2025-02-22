using System;
namespace Nunit_Assignment
{
    public class DatabaseConnection
    {
        public bool IsConnected { get; private set; }

        // Simulating database connection
        public void Connect()
        {
            IsConnected = true;
            Console.WriteLine("Database connected.");
        }

        // Simulating closing the database connection
        public void Disconnect()
        {
            IsConnected = false;
            Console.WriteLine("Database disconnected.");
        }
    }
}
