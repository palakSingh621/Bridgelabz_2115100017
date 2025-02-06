using System;
using System.Collections.Generic;
namespace Assignment_11_OOPs
{
    class Patient
    {
        public string PatientName { get; set; }
        //Patient Constructor
        public Patient(string patientName)
        {
            PatientName = patientName;
        }
        //Method to display Patient details
        public void DisplayDetails()
        {
            Console.WriteLine("Patient Name: " + PatientName);
        }
    }
    class Doctor
    {
        public string DoctorName { get; set; }
        private List<Patient> Patients { get; set; }
        //Doctor Constructor
        public Doctor(string doctorName)
        {
            DoctorName = doctorName;
            Patients = new List<Patient>();
        }
        //Method to add Patient
        public void AddPatient(Patient patient)
        {
            Patients.Add(patient);
        }
        //Method to get doctor name consulting the patient
        public void Consult(Patient patient)
        {
            Console.WriteLine(DoctorName + " is consulting Patient " + patient.PatientName);
            Console.WriteLine();
        }
        // display patient details
        public void DisplayPatients()
        {
            Console.WriteLine("Patients under " + DoctorName + ":");
            foreach (var patient in Patients)
            {
                patient.DisplayDetails();
            }
            Console.WriteLine();
        }
    }
    class Hospital
    {
        public string HospitalName { get; set; }
        private List<Doctor> Doctors { get; set; }
        //Hospital Constructor
        public Hospital(string hospitalName)
        {
            HospitalName = hospitalName;
            Doctors = new List<Doctor>();
        }
        // Method to add doctor
        public void AddDoctor(Doctor doctor)
        {
            Doctors.Add(doctor);
        }
        // Method to display Hosplital detials
        public void DisplayDetails()
        {
            Console.WriteLine("Hospital Name: " + HospitalName);
            Console.WriteLine();
            foreach (var doctor in Doctors)
            {
                doctor.DisplayPatients();
            }
        }
    }
    internal class HospitalManagement
    {
        static void Main()
        {
            Hospital hospital = new Hospital("City Hospital");
            Doctor doctor1 = new Doctor("Dr. Singh");
            Doctor doctor2 = new Doctor("Dr. Arora");
            Patient patient1 = new Patient("Palak");
            Patient patient2 = new Patient("Yash");
            doctor1.AddPatient(patient1);
            doctor1.AddPatient(patient2);
            doctor2.AddPatient(patient1);
            doctor1.Consult(patient1);
            doctor2.Consult(patient2);
            hospital.AddDoctor(doctor1);
            hospital.AddDoctor(doctor2);
            hospital.DisplayDetails();
        }
    }
}
