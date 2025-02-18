using System;
using System.Collections.Generic;
namespace Assignment_19_Generics
{
    //abstract class representing a Job Role
    public abstract class JobRole
    {
        public string RoleName { get; set; }
        public string Description { get; set; }

        //abstract method to screen resumes for the job role
        public abstract void ScreenResume(string resume);
    }

    //Software Engineer role
    public class SoftwareEngineer : JobRole
    {
        public SoftwareEngineer()
        {
            RoleName = "Software Engineer";
            Description = "Responsible for developing, testing, and maintaining software applications.";
        }

        public override void ScreenResume(string resume)
        {
            Console.WriteLine("Screening Software Engineer resume...");
            //resume screening logic specific to Software Engineer
            Console.WriteLine("Resume processed for: " + RoleName);
        }
    }

    //data Scientist role
    public class DataScientist : JobRole
    {
        public DataScientist()
        {
            RoleName = "Data Scientist";
            Description = "Responsible for analyzing and interpreting complex data to help companies make decisions.";
        }

        public override void ScreenResume(string resume)
        {
            Console.WriteLine("Screening Data Scientist resume...");
            //resume screening logic specific to Data Scientist
            Console.WriteLine("Resume processed for: " + RoleName);
        }
    }

    //generic Resume class that can handle any JobRole
    public class Resume<T> where T : JobRole, new()
    {
        public T JobRole { get; set; }

        public Resume()
        {
            JobRole = new T();
        }

        //method to process resumes dynamically based on the job role
        public void ProcessResume(string resume)
        {
            Console.WriteLine("Processing resume for: " + JobRole.RoleName);
            JobRole.ScreenResume(resume);
        }
    }

    public class ResumeScreeningSystem
    {
        //method to screen a list of resumes for multiple job roles
        public void ScreenResumes<T>(List<T> jobRoles, string resume) where T : JobRole
        {
            foreach (var jobRole in jobRoles)
            {
                Console.WriteLine("Processing " + jobRole.RoleName + " resume:");
                jobRole.ScreenResume(resume);
            }
        }
    }

    class program5
    {
        static void Main()
        {
            //list of job roles to screen resumes for
            List<JobRole> jobRoles = new List<JobRole>
        {
            new SoftwareEngineer(),
            new DataScientist()
        };

            //resume text to be screened
            string resumeText = "Resume content goes here...";

            //create a ResumeScreeningSystem instance and screen resumes for the job roles
            ResumeScreeningSystem screeningSystem = new ResumeScreeningSystem();
            screeningSystem.ScreenResumes(jobRoles, resumeText);

            //using the generic Resume class to process resumes dynamically
            Resume<SoftwareEngineer> softwareEngineerResume = new Resume<SoftwareEngineer>();
            softwareEngineerResume.ProcessResume(resumeText);

            Resume<DataScientist> dataScientistResume = new Resume<DataScientist>();
            dataScientistResume.ProcessResume(resumeText);
        }
    }
}
