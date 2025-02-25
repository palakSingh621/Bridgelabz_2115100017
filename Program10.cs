using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVDataHandling
{
    class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Marks { get; set; }
        public string Grade { get; set; }

        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Age: {Age}, Marks: {Marks}, Grade: {Grade}";
        }
    }

    class Program10
    {
        static void Main()
        {
            string file1 = "students1.csv";
            string file2 = "students2.csv";
            string mergedFile = "merged_students.csv";

            // Writing sample data to students1.csv
            using (StreamWriter writer = new StreamWriter(file1))
            {
                writer.WriteLine("ID,Name,Age");
                writer.WriteLine("101,John Doe,20");
                writer.WriteLine("102,Jane Smith,22");
                writer.WriteLine("103,Michael Brown,21");
                writer.WriteLine("104,Emily Davis,23");
                writer.WriteLine("105,David Wilson,19");
            }

            // Writing sample data to students2.csv
            using (StreamWriter writer = new StreamWriter(file2))
            {
                writer.WriteLine("ID,Marks,Grade");
                writer.WriteLine("101,85,A");
                writer.WriteLine("102,78,B");
                writer.WriteLine("103,92,A+");
                writer.WriteLine("104,75,B");
                writer.WriteLine("105,88,A");
            }

            // Reading students1.csv
            Dictionary<int, Student> students = new Dictionary<int, Student>();
            using (StreamReader reader = new StreamReader(file1))
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

                    string[] values = line.Split(',');
                    students[int.Parse(values[0])] = new Student
                    {
                        ID = int.Parse(values[0]),
                        Name = values[1],
                        Age = int.Parse(values[2])
                    };
                }
            }

            // Reading students2.csv and merging data
            using (StreamReader reader = new StreamReader(file2))
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

                    string[] values = line.Split(',');
                    int id = int.Parse(values[0]);
                    if (students.ContainsKey(id))
                    {
                        students[id].Marks = int.Parse(values[1]);
                        students[id].Grade = values[2];
                    }
                }
            }

            // Writing merged data to a new CSV file
            using (StreamWriter writer = new StreamWriter(mergedFile))
            {
                writer.WriteLine("ID,Name,Age,Marks,Grade");
                foreach (var student in students.Values)
                {
                    writer.WriteLine($"{student.ID},{student.Name},{student.Age},{student.Marks},{student.Grade}");
                }
            }

            Console.WriteLine("Merged CSV file created successfully.");

            // Printing merged student objects
            Console.WriteLine("Merged Students List:");
            foreach (var student in students.Values)
            {
                Console.WriteLine(student);
            }
        }
    }

}
