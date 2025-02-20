using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
namespace Assignment_21_Streams
{
    [Serializable]
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Department: {Department}, Salary: {Salary:C}";
        }
    }

    class EmployeeSerialization
    {
        static string filePath = "employees.json"; // File to store employee data

        static void Main()
        {
            List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 101, Name = "Alice", Department = "IT", Salary = 75000 },
            new Employee { Id = 102, Name = "Bob", Department = "HR", Salary = 68000 },
            new Employee { Id = 103, Name = "Charlie", Department = "Finance", Salary = 80000 }
        };

            // Serialize Employee List
            SerializeEmployees(employees);

            // Deserialize and Display Employees
            List<Employee> retrievedEmployees = DeserializeEmployees();
            Console.WriteLine("\nRetrieved Employees:");
            foreach (var emp in retrievedEmployees)
            {
                Console.WriteLine(emp);
            }
        }

        static void SerializeEmployees(List<Employee> employees)
        {
            try
            {
                string jsonString = JsonSerializer.Serialize(employees, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(filePath, jsonString);
                Console.WriteLine("Employees serialized successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error during serialization: {ex.Message}");
            }
        }

        static List<Employee> DeserializeEmployees()
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    Console.WriteLine("No data found. Please serialize first.");
                    return new List<Employee>();
                }

                string jsonString = File.ReadAllText(filePath);
                return JsonSerializer.Deserialize<List<Employee>>(jsonString) ?? new List<Employee>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error during deserialization: {ex.Message}");
                return new List<Employee>();
            }
        }
    }
}
