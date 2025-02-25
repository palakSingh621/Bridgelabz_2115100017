using System;
using System.Collections.Generic;
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
    class Program11
    {
        static void Main()
        {
            string largeCsvFile = "large_students.csv";
            int chunkSize = 100;
            int totalRecords = 0;

            using (StreamReader reader = new StreamReader(largeCsvFile))
            {
                string line;
                bool isHeader = true;
                List<string> chunk = new List<string>();

                while ((line = reader.ReadLine()) != null)
                {
                    if (isHeader)
                    {
                        isHeader = false;
                        continue;
                    }

                    chunk.Add(line);
                    totalRecords++;

                    if (chunk.Count >= chunkSize)
                    {
                        ProcessChunk(chunk);
                        chunk.Clear();
                    }
                }

                if (chunk.Count > 0)
                {
                    ProcessChunk(chunk);
                }
            }

            Console.WriteLine($"Total records processed: {totalRecords}");
        }

        static void ProcessChunk(List<string> chunk)
        {
            Console.WriteLine($"Processing {chunk.Count} records...");
            // Additional processing logic can be implemented here
        }
    }

}
