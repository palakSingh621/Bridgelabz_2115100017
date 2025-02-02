using System;
using System.Xml.Linq;
namespace Constructors_Assignment
{
    internal class Person
    {
        public string name;
        public int age;
        public Person(string name, int age) // Parameterized constructor
        {
            this.name = name;
            this.age = age;
        }
        public Person(Person person) // Copy constructor
        {
            name = person.name;
            age = person.age;
        }
        //Display result
        public void DisplayResult()
        {
            Console.WriteLine("The name of the person is " + name);
            Console.WriteLine("The age of the person is " + age);
        }
        static void Main(String[] args)
        {
            Person person1 = new Person("Palak", 23);
            person1.DisplayResult();
            Console.WriteLine(" ");
            Person person2 = new Person(person1);
            person2.DisplayResult();
        }
    }
}
