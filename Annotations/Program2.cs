using System;
namespace Annotaions_Assisgnment1
{
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
    class Program2
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
        }
    }

}
