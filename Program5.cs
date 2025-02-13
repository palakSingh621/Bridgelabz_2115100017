using System;
using System.Collections.Generic;
namespace Assignment_15_DSA2
{
    class PetrolPump
    {
        public int Petrol { get; set; }
        public int Distance { get; set; }

        public PetrolPump(int petrol, int distance)
        {
            Petrol = petrol;
            Distance = distance;
        }
    }
    internal class Program5
    {
        static int FindStartingPoint(List<PetrolPump> petrolPumps)
        {
            int n = petrolPumps.Count;
            int start = 0;
            int end = 1;
            int currentPetrol = petrolPumps[start].Petrol - petrolPumps[start].Distance;

            while (end != start || currentPetrol < 0)
            {
                // Remove petrol pump from the current tour if currentPetrol is negative
                while (currentPetrol < 0 && start != end)
                {
                    currentPetrol -= petrolPumps[start].Petrol - petrolPumps[start].Distance;
                    start = (start + 1) % n;

                    // If we are back to the first petrol pump, no solution
                    if (start == 0)
                    {
                        return -1; // No solution
                    }
                }

                // Add petrol for the next pump
                currentPetrol += petrolPumps[end].Petrol - petrolPumps[end].Distance;
                end = (end + 1) % n;
            }

            return start;
        }

        static void Main(string[] args)
        {
            List<PetrolPump> petrolPumps = new List<PetrolPump>
        {
            new PetrolPump(6, 4),
            new PetrolPump(3, 6),
            new PetrolPump(7, 3)
        };

            int startingPoint = FindStartingPoint(petrolPumps);

            if (startingPoint != -1)
            {
                Console.WriteLine("The starting point is petrol pump index: " + startingPoint);
            }
            else
            {
                Console.WriteLine("No solution exists for completing the circular tour.");
            }
        }
    }
}
