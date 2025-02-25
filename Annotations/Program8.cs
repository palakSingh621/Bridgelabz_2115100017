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

            // Retrieve and display BugReport attributes using Reflection
            MethodInfo bugMethod = typeof(TaskManager).GetMethod("ProcessTask");
            object[] bugReports = bugMethod.GetCustomAttributes(typeof(BugReportAttribute), false);

            foreach (BugReportAttribute bug in bugReports)
            {
                Console.WriteLine($"Bug Report: {bug.Description}");
            }

            // Retrieve and display ImportantMethod attributes using Reflection
            MethodInfo[] methods = typeof(TaskManager).GetMethods();
            foreach (var method in methods)
            {
                object[] attributes = method.GetCustomAttributes(typeof(ImportantMethodAttribute), false);
                foreach (ImportantMethodAttribute attr in attributes)
                {
                    Console.WriteLine($"Important Method: {method.Name}, Level: {attr.Level}");
                }
            }

            // Retrieve and display Todo attributes using Reflection
            MethodInfo pendingMethod = typeof(TaskManager).GetMethod("PendingTask");
            object[] todos = pendingMethod.GetCustomAttributes(typeof(TodoAttribute), false);

            foreach (TodoAttribute todo in todos)
            {
                Console.WriteLine($"Pending Task: {todo.Task}, Assigned To: {todo.AssignedTo}, Priority: {todo.Priority}");
            }

            // Execute and measure execution time for methods with LogExecutionTime
            TaskManager taskManager = new TaskManager();
            taskManager.TimeConsumingTask();
        }
    }
}
