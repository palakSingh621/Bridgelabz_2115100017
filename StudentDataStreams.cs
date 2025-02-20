using System;
using System.IO;
namespace Assignment_21_Streams
{
    class StudentDataStreams
    {
        static string filePath = "students.dat"; 
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("\n1. Store Student Data");
                Console.WriteLine("2. Retrieve Student Data");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");
                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }
                switch (choice)
                {
                    case 1:
                        StoreStudentData();
                        break;
                    case 2:
                        RetrieveStudentData();
                        break;
                    case 3:
                        Console.WriteLine("Exiting program...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice! Please enter 1, 2, or 3.");
                        break;
                }
            }
        }
        static void StoreStudentData()
        {
            try
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Append, FileAccess.Write))
                using (BinaryWriter writer = new BinaryWriter(fs))
                {
                    Console.Write("\nEnter Roll Number: ");
                    int rollNumber = int.Parse(Console.ReadLine());

                    Console.Write("Enter Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Enter GPA: ");
                    double gpa = double.Parse(Console.ReadLine());

                    writer.Write(rollNumber);
                    writer.Write(name);
                    writer.Write(gpa);

                    Console.WriteLine("Student data stored successfully!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error storing student data: {ex.Message}");
            }
        }
        static void RetrieveStudentData()
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("No student data found.");
                return;
            }
            try
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                using (BinaryReader reader = new BinaryReader(fs))
                {
                    Console.WriteLine("\n--- Student Details ---");

                    while (fs.Position < fs.Length)  // Read till end of file
                    {
                        int rollNumber = reader.ReadInt32();
                        string name = reader.ReadString();
                        double gpa = reader.ReadDouble();

                        Console.WriteLine($"Roll Number: {rollNumber}, Name: {name}, GPA: {gpa}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving student data: {ex.Message}");
            }
        }
    }
}
