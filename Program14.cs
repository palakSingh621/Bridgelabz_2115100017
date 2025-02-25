using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace CSVDataHandling
{
    class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Marks { get; set; }
    }

    class Program
    {
        static void Main()
        {
            string jsonFile = "students.json";
            string csvFile = "students.csv";

            ConvertJsonToCsv(jsonFile, csvFile);
            ConvertCsvToJson(csvFile, "converted_students.json");
        }

        static void ConvertJsonToCsv(string jsonFile, string csvFile)
        {
            var students = JsonConvert.DeserializeObject<List<Student>>(File.ReadAllText(jsonFile));
            using (StreamWriter writer = new StreamWriter(csvFile))
            {
                writer.WriteLine("ID,Name,Age,Marks");
                foreach (var student in students)
                {
                    writer.WriteLine($"{student.ID},{student.Name},{student.Age},{student.Marks}");
                }
            }
            Console.WriteLine("JSON converted to CSV successfully!");
        }

        static void ConvertCsvToJson(string csvFile, string jsonFile)
        {
            List<Student> students = new List<Student>();
            using (StreamReader reader = new StreamReader(csvFile))
            {
                string line;
                bool isHeader = true;
                while ((line = reader.ReadLine()) != null)
                {
                    if (isHeader)
                    {
                        isHeader = false;
                        continue;
                    }
                    string[] parts = line.Split(',');
                    if (parts.Length == 4)
                    {
                        students.Add(new Student
                        {
                            ID = int.Parse(parts[0]),
                            Name = parts[1],
                            Age = int.Parse(parts[2]),
                            Marks = int.Parse(parts[3])
                        });
                    }
                }
            }
            File.WriteAllText(jsonFile, JsonConvert.SerializeObject(students, Formatting.Indented));
            Console.WriteLine("CSV converted to JSON successfully!");
        }
    }
}
