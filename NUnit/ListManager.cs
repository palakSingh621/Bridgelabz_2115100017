using System;
using System.Collections.Generic;
namespace Nunit_Assignment
{
    public class ListManager
    {
        // Adds an element to the list
        public void AddElement(List<int> list, int element)
        {
            if (list == null)
                throw new ArgumentNullException(nameof(list));

            list.Add(element);
        }

        // Removes an element from the list
        public bool RemoveElement(List<int> list, int element)
        {
            if (list == null)
                throw new ArgumentNullException(nameof(list));

            return list.Remove(element);
        }

        // Returns the size of the list
        public int GetSize(List<int> list)
        {
            if (list == null)
                throw new ArgumentNullException(nameof(list));

            return list.Count;
        }
    }
}
