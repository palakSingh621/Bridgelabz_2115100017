using System;
using System.Collections;
using System.Diagnostics;
using System.Reflection;
namespace Annotaions_Assisgnment1
{
    // Custom Attribute for Task Info
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

    // Custom Repeatable Attribute for Bug Reports
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    class BugReportAttribute : Attribute
    {
        public string Description { get; }

        public BugReportAttribute(string description)
        {
            Description = description;
        }
    }

    // Custom Attribute for Important Methods
    [AttributeUsage(AttributeTargets.Method)]
    class ImportantMethodAttribute : Attribute
    {
        public string Level { get; }

        public ImportantMethodAttribute(string level = "HIGH")
        {
            Level = level;
        }
    }

    // Custom Attribute for Todo
    [AttributeUsage(AttributeTargets.Method)]
    class TodoAttribute : Attribute
    {
        public string Task { get; }
        public string AssignedTo { get; }
        public string Priority { get; }

        public TodoAttribute(string task, string assignedTo, string priority = "MEDIUM")
        {
            Task = task;
            AssignedTo = assignedTo;
            Priority = priority;
        }
    }

    // Custom Attribute for Logging Execution Time
    [AttributeUsage(AttributeTargets.Method)]
    class LogExecutionTimeAttribute : Attribute
    {
    }

    // Custom Attribute for Role-Based Access Control
    [AttributeUsage(AttributeTargets.Method)]
    class RoleAllowedAttribute : Attribute
    {
        public string Role { get; }

        public RoleAllowedAttribute(string role)
        {
            Role = role;
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

        [BugReport("Null reference exception in edge cases")]
        [BugReport("Performance issue with large data sets")]
        public void ProcessTask()
        {
            Console.WriteLine("Processing task...");
        }

        [ImportantMethod]
        public void CriticalOperation()
        {
            Console.WriteLine("Performing a critical operation...");
        }

        [ImportantMethod("MEDIUM")]
        public void RegularOperation()
        {
            Console.WriteLine("Performing a regular operation...");
        }

        [Todo("Implement caching mechanism", "Alice")]
        [Todo("Optimize database queries", "Bob", "HIGH")]
        public void PendingTask()
        {
            Console.WriteLine("Working on pending task...");
        }

        [LogExecutionTime]
        public void TimeConsumingTask()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            System.Threading.Thread.Sleep(500); // Simulate time delay
            stopwatch.Stop();
            Console.WriteLine($"TimeConsumingTask executed in {stopwatch.ElapsedMilliseconds} ms");
        }

        [RoleAllowed("ADMIN")]
        public void AdminTask()
        {
            Console.WriteLine("Admin task executed successfully.");
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

            // Execute and validate role-based access control
            TaskManager taskManager = new TaskManager();
            ExecuteIfAllowed(taskManager, "AdminTask", "USER"); // Should print "Access Denied!"
            ExecuteIfAllowed(taskManager, "AdminTask", "ADMIN"); // Should execute successfully
        }

        static void ExecuteIfAllowed(object obj, string methodName, string userRole)
        {
            MethodInfo method = obj.GetType().GetMethod(methodName);
            RoleAllowedAttribute roleAttr = (RoleAllowedAttribute)Attribute.GetCustomAttribute(method, typeof(RoleAllowedAttribute));

            if (roleAttr != null && roleAttr.Role != userRole)
            {
                Console.WriteLine("Access Denied!");
                return;
            }

            method.Invoke(obj, null);
        }
    }
}
