using System;
using System.Collections.Generic;
namespace Assignment_15_DSA2
{
    internal class Program9
    {
        private const int SIZE = 1000;
        private LinkedList<KeyValuePair<int, string>>[] buckets;
        public Program9()
        {
            buckets = new LinkedList<KeyValuePair<int, string>>[SIZE];
            for (int i = 0; i < SIZE; i++)
                buckets[i] = new LinkedList<KeyValuePair<int, string>>();
        }
        private int GetHash(int key) => Math.Abs(key.GetHashCode()) % SIZE;
        public void Put(int key, string value)
        {
            int index = GetHash(key);
            foreach (var pair in buckets[index])
            {
                if (pair.Key.Equals(key))
                {
                    buckets[index].Remove(pair);
                    break;
                }
            }
            buckets[index].AddLast(new KeyValuePair<int, string>(key, value));
        }
        public string Get(int key)
        {
            int index = GetHash(key);
            foreach (var pair in buckets[index])
            {
                if (pair.Key.Equals(key))
                    return pair.Value;
            }
            throw new KeyNotFoundException("Key not found");
        }
        public void Remove(int key)
        {
            int index = GetHash(key);
            foreach (var pair in buckets[index])
            {
                if (pair.Key.Equals(key))
                {
                    buckets[index].Remove(pair);
                    return;
                }
            }
        }
        static void Main()
        {
            Program9 map = new Program9();
            map.Put(1, "One");
            map.Put(2, "Two");
            Console.WriteLine(map.Get(1));
            Console.WriteLine(map.Get(2));
            map.Remove(1);
            try { Console.WriteLine(map.Get(1)); }
            catch (KeyNotFoundException e) { Console.WriteLine(e.Message); }
        }
    }
}
