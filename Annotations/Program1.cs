using System;
namespace Annotaions_Assisgnment1
{
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
    class Program1
    {
        static void Main()
        {
            // Instantiate Dog and call MakeSound()
            Animal myDog = new Dog();
            myDog.MakeSound();
        }
    }

}
