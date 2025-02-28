using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using Newtonsoft.Json;

namespace JSONHandeling
{
    internal class Program15
    {
        static void Main()
        {
            string connectionString = "Server=YOUR_SERVER;Database=YOUR_DATABASE;User Id=YOUR_USER;Password=YOUR_PASSWORD;";
            string query = "SELECT Id, Name, Age, Email FROM Students";

            var studentList = new List<Student>();

            // Connect to database and fetch records
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        studentList.Add(new Student
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Age = reader.GetInt32(2),
                            Email = reader.GetString(3)
                        });
                    }
                }
            }

            // Convert records to JSON
            string jsonReport = JsonConvert.SerializeObject(studentList, Formatting.Indented);

            // Save JSON report to a file
            File.WriteAllText("StudentReport.json", jsonReport);

            Console.WriteLine("JSON Report Generated:\n" + jsonReport);
        }
    }

    // Student class model
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
    }

}
