using System;
using System.Collections.Generic;
namespace Assignment_20_Collections
{
    internal class Map2
    {
        static void Main()
        {
            Dictionary<string, int> inputMap = new Dictionary<string, int>
            {
                { "A", 1 },
                { "B", 2 },
                { "C", 1 }
            };
            // Inverting the dictionary
            Dictionary<int, List<string>> invertedMap = InvertDictionary(inputMap);
            foreach (var entry in invertedMap)
            {
                Console.WriteLine($"{entry.Key} = [{string.Join(", ", entry.Value)}]");
            }
        }
        static Dictionary<V, List<K>> InvertDictionary<K, V>(Dictionary<K, V> original)
        {
            Dictionary<V, List<K>> inverted = new Dictionary<V, List<K>>();

            foreach (var pair in original)
            {
                if (!inverted.ContainsKey(pair.Value))
                {
                    inverted[pair.Value] = new List<K>();
                }
                inverted[pair.Value].Add(pair.Key);
            }
            return inverted;
        }
    }
}
