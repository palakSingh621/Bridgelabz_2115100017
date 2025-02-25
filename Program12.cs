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
    class Program12
    {
        static void Main()
        {
            string csvFile = "students.csv";
            DetectDuplicates(csvFile);
        }

        static void DetectDuplicates(string csvFile)
        {
            var studentRecords = new Dictionary<int, List<string>>();
            bool isHeader = true;

            using (StreamReader reader = new StreamReader(csvFile))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (isHeader)
                    {
                        isHeader = false;
                        continue;
                    }

                    string[] parts = line.Split(',');
                    if (parts.Length < 2) continue;

                    if (int.TryParse(parts[0], out int id))
                    {
                        if (!studentRecords.ContainsKey(id))
                        {
                            studentRecords[id] = new List<string>();
                        }
                        studentRecords[id].Add(line);
                    }
                }
            }

            Console.WriteLine("Duplicate Records:");
            foreach (var entry in studentRecords.Where(e => e.Value.Count > 1))
            {
                foreach (var record in entry.Value)
                {
                    Console.WriteLine(record);
                }
            }
        }
    }

}
