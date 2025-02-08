using System;
namespace Assignment_12_Inheritance
{
    class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }
    // Derived class Dog
    class Dog : Animal
    {
        public Dog(string name, int age) : base(name, age) { }
        public override void MakeSound()
        {
            Console.WriteLine("Dog barks");
        }
    }
    // Derived class Cat
    class Cat : Animal
    {
        public Cat(string name, int age) : base(name, age) { }
        public override void MakeSound()
        {
            Console.WriteLine("Cat meows");
        }
    }
    // Derived class Bird
    class Bird : Animal
    {
        public Bird(string name, int age) : base(name, age) { }
        public override void MakeSound()
        {
            Console.WriteLine("Bird chirps");
        }
    }
    internal class Program1
    {
        static void Main(string[] args)
        {
            Animal myDog = new Dog("Buddy", 3);
            Animal myCat = new Cat("Whiskers", 2);
            Animal myBird = new Bird("Tweety", 1);
            myDog.MakeSound();
            myCat.MakeSound();
            myBird.MakeSound();
        }
    }
}
