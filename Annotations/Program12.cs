using System;
using System.Collections;
using System.Collections.Generic;
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

    // Custom Attribute for JSON Serialization
    [AttributeUsage(AttributeTargets.Field)]
    class JsonFieldAttribute : Attribute
    {
        public string Name { get; }

        public JsonFieldAttribute(string name)
        {
            Name = name;
        }
    }

    // Custom Attribute for Caching
    [AttributeUsage(AttributeTargets.Method)]
    class CacheResultAttribute : Attribute
    {
    }

    // User class with JsonField attribute
    class User
    {
        [JsonField("user_name")]
        public string Username;

        public User(string username)
        {
            Username = username;
        }
    }

    class JsonSerializerHelper
    {
        public static string SerializeToJson(object obj)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            var jsonObject = new Dictionary<string, object>();

            foreach (var field in obj.GetType().GetFields())
            {
                var attr = (JsonFieldAttribute)Attribute.GetCustomAttribute(field, typeof(JsonFieldAttribute));
                string key = attr != null ? attr.Name : field.Name;
                jsonObject[key] = field.GetValue(obj);
            }

            return JsonSerializer.Serialize(jsonObject, options);
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

        private static Dictionary<int, long> cache = new Dictionary<int, long>();

        [CacheResult]
        public long Fibonacci(int n)
        {
            if (cache.ContainsKey(n))
            {
                Console.WriteLine($"Returning cached result for Fibonacci({n})");
                return cache[n];
            }

            if (n <= 1) return n;

            long result = Fibonacci(n - 1) + Fibonacci(n - 2);
            cache[n] = result;
            return result;
        }
    }

    class Program
    {
        static void Main()
        {
            Animal myDog = new Dog();
            myDog.MakeSound();

            LegacyAPI api = new LegacyAPI();
            api.OldFeature();
            api.NewFeature();

#pragma warning disable CS8600, CS8602
            ArrayList list = new ArrayList();
            list.Add("Hello");
            list.Add(42);
#pragma warning restore CS8600, CS8602

            TaskManager taskManager = new TaskManager();
            ExecuteIfAllowed(taskManager, "AdminTask", "USER");
            ExecuteIfAllowed(taskManager, "AdminTask", "ADMIN");

            User user = new User("john_doe");
            string json = JsonSerializerHelper.SerializeToJson(user);
            Console.WriteLine("Serialized JSON:");
            Console.WriteLine(json);

            Console.WriteLine("Computing Fibonacci(10): " + taskManager.Fibonacci(10));
            Console.WriteLine("Computing Fibonacci(10) again: " + taskManager.Fibonacci(10));
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
