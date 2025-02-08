using System;
namespace Assignment_12_Inheritance
{
    interface IWorker
    {
        void PerformDuties();
    }
    class Person
    {
        //Attributes
        public string Name { get; set; }
        public int Id { get; set; }
        //Constructor
        public Person(string name, int id)
        {
            Name = name;
            Id = id;
        }
        //method to display details
        public void ShowInfo()
        {
            Console.WriteLine("Name: " + Name + ", ID: " + Id);
        }
    }
    class Chef : Person, IWorker
    {
        //Constructor
        public Chef(string name, int id) : base(name, id) { }

        //method implementation of the interface
        public void PerformDuties()
        {
            Console.WriteLine(Name + " is preparing meals.");
        }
    }
    class Waiter : Person, IWorker
    {
        //Constructor
        public Waiter(string name, int id) : base(name, id) { }

        //method implementation of the interface
        public void PerformDuties()
        {
            Console.WriteLine(Name + " is serving customers.");
        }
    }

    internal class Program10
    {
        static void Main(string[] args)
        {
            Chef chef = new Chef("Gajendra", 101);
            Waiter waiter = new Waiter("Amitabh", 201);

            chef.ShowInfo();
            chef.PerformDuties();

            waiter.ShowInfo();
            waiter.PerformDuties();
        }
    }
}
