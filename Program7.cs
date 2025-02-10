using System;
using System.Collections.Generic;
namespace Assignment_13_Encapsulation
{
    interface IMedicalRecord
    {
        void AddRecord(string record);
        void ViewRecords();
    }

    internal abstract class Patient
    {
        //Attributes
        private string patientId;
        private string name;
        private int age;
        protected List<string> medicalRecords;

        //properties for encapsulation
        public string PatientId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        //Constructor
        public Patient(string patientId, string name, int age)
        {
            PatientId = patientId;
            Name = name;
            Age = age;
            medicalRecords = new List<string>();
        }

        //abstract method to calculate bill
        public abstract double CalculateBill();

        //concrete method to get patient details
        public void GetPatientDetails()
        {
            Console.WriteLine("Patient ID: " + PatientId);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
        }
    }

    class InPatient : Patient, IMedicalRecord
    {
        public int NumberOfDays { get; set; }
        public double DailyRate { get; set; }

        public InPatient(string patientId, string name, int age, int numberOfDays, double dailyRate)
            : base(patientId, name, age)
        {
            NumberOfDays = numberOfDays;
            DailyRate = dailyRate;
        }

        public override double CalculateBill()
        {
            double bill = NumberOfDays * DailyRate;
            Console.WriteLine("The bill for In-Patient " + Name + " is " + bill);
            return bill;
        }

        public void AddRecord(string record)
        {
            medicalRecords.Add(record);
            Console.WriteLine("Medical record added for " + Name);
        }

        public void ViewRecords()
        {
            Console.WriteLine("Medical records for " + Name + ":");
            foreach (var record in medicalRecords)
            {
                Console.WriteLine(record);
            }
        }
    }

    class OutPatient : Patient, IMedicalRecord
    {
        public double ConsultationFee { get; set; }

        public OutPatient(string patientId, string name, int age, double consultationFee)
            : base(patientId, name, age)
        {
            ConsultationFee = consultationFee;
        }

        public override double CalculateBill()
        {
            double bill = ConsultationFee;
            Console.WriteLine("The bill for Out-Patient " + Name + " is " + bill);
            return bill;
        }

        public void AddRecord(string record)
        {
            medicalRecords.Add(record);
            Console.WriteLine("Medical record added for " + Name);
        }

        public void ViewRecords()
        {
            Console.WriteLine("Medical records for " + Name + ":");
            foreach (var record in medicalRecords)
            {
                Console.WriteLine(record);
            }
        }
    }

    class program6
    {
        public static void Main(string[] args)
        {
            List<Patient> patients = new List<Patient>
            {
                new InPatient("P1", "Kajol", 45, 5, 1500),
                new OutPatient("P2", "Priyanka", 30, 500)
            };

            foreach (Patient patient in patients)
            {
                patient.GetPatientDetails();
                patient.CalculateBill();

                if (patient is IMedicalRecord recordKeeper)
                {
                    recordKeeper.AddRecord("Initial diagnosis: Fever");
                    recordKeeper.ViewRecords();
                }

                Console.WriteLine();
            }
        }
    }
}
