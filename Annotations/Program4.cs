using System;
using System.Collections;
using System.Reflection;
namespace Annotaions_Assisgnment1
{
    // Custom Attribute
    [AttributeUsage(AttributeTargets.Method)]
    class TaskInfoAttribute : Attribute
    {
        public string Priority { get; }
        public string AssignedTo { get; }

        public TaskInfoAttribute(string priority, string assignedTo)
        {
            Priority = priority;
            AssignedTo = assignedTo;
        }
    }

    // Parent class
    class Animal
    {
        // Virtual method to be overridden
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }

    // Derived class
    class Dog : Animal
    {
        // Overriding the MakeSound method
        public override void MakeSound()
        {
            Console.WriteLine("Dog barks");
        }
    }

    // Legacy API class
    class LegacyAPI
    {
        [Obsolete("OldFeature is deprecated, use NewFeature instead.")]
        public void OldFeature()
        {
            Console.WriteLine("This is an old feature");
        }

        public void NewFeature()
        {
            Console.WriteLine("This is the new feature");
        }
    }

    // Task Manager class
    class TaskManager
    {
        [TaskInfo("High", "John Doe")]
        public void ExecuteTask()
        {
            Console.WriteLine("Executing task...");
        }
    }

    class Program
    {
        static void Main()
        {
            // Instantiate Dog and call MakeSound()
            Animal myDog = new Dog();
            myDog.MakeSound();

            // Instantiate LegacyAPI and call both methods
            LegacyAPI api = new LegacyAPI();
            api.OldFeature(); // This should show a warning
            api.NewFeature();

            // Suppress warnings for unchecked operations
#pragma warning disable CS8600, CS8602
            ArrayList list = new ArrayList();
            list.Add("Hello");
            list.Add(42);
#pragma warning restore CS8600, CS8602

            // Retrieve and display TaskInfo attribute details using Reflection
            MethodInfo methodInfo = typeof(TaskManager).GetMethod("ExecuteTask");
            TaskInfoAttribute taskInfo = (TaskInfoAttribute)Attribute.GetCustomAttribute(methodInfo, typeof(TaskInfoAttribute));

            if (taskInfo != null)
            {
                Console.WriteLine($"Task Priority: {taskInfo.Priority}, Assigned To: {taskInfo.AssignedTo}");
            }
        }
    }

}
