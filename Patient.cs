using System;
namespace Assignment_10
{
    internal class Patient
    {
        //attributes
        public static string hospitalName= "Military Hospital";
        static int totalPatients = 0;
        string name;
        int age;
        string ailment;
        readonly int patientID;
        //constructor
        public Patient(int patientID, string name, int age, string ailment)
        {
            this.patientID = patientID;
            this.name = name;
            this.age = age;
            this.ailment = ailment;
            totalPatients++;
        }
        //get method for total patient count
        public static int GetTotalPatients()
        {
            return totalPatients;
        }
        //Method to dispaly patients details
        public void DisplayPatient()
        {
            Console.WriteLine("Patient ID: " + patientID);
            Console.WriteLine("Patient Name: " +name);
            Console.WriteLine("Age: "+age);
            Console.WriteLine("Ailment: "+ailment);
            Console.WriteLine();
        }
    }
    class Program7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hospital Name: " + Patient.hospitalName);
            Console.WriteLine();
            Patient patient_1 = new Patient(065,"Roy", 65, "Pancreatic Cancer");
            Patient patient_2 = new Patient(097, "Herani", 28, "Ankle Sprain");
            patient_1.DisplayPatient();
            patient_2.DisplayPatient();
            Console.WriteLine("Total Patients: " + Patient.GetTotalPatients());
        }
    }
}
