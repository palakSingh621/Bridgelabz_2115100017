using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
namespace CSVDataHandling
{
    class Employee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }
    }

    class Program
    {
        static void Main()
        {
            string connectionString = "your_connection_string_here";
            string csvFile = "employees.csv";
            GenerateCsvReport(connectionString, csvFile);
        }

        static void GenerateCsvReport(string connectionString, string csvFile)
        {
            List<Employee> employees = new List<Employee>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT EmployeeID, Name, Department, Salary FROM Employees";
                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        employees.Add(new Employee
                        {
                            EmployeeID = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Department = reader.GetString(2),
                            Salary = reader.GetDecimal(3)
                        });
                    }
                }
            }

            using (StreamWriter writer = new StreamWriter(csvFile))
            {
                writer.WriteLine("Employee ID,Name,Department,Salary");
                foreach (var emp in employees)
                {
                    writer.WriteLine($"{emp.EmployeeID},{emp.Name},{emp.Department},{emp.Salary}");
                }
            }

            Console.WriteLine("CSV report generated successfully!");
        }
    }
}
