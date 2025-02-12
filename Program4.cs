using System;
namespace Assignment_14_LinkedList
{
    class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Item Next;
        public Item(int id, string name, int quantity, double price)
        {
            Id = id;
            Name = name;
            Quantity = quantity;
            Price = price;
            Next = null;
        }
    }
    class Inventory
    {
        public Item head;
        //Method to add an item at the beginning
        public void AddItemAtBeginning(int id, string name, int quantity, double price)
        {
            Item newItem = new Item(id, name, quantity, price);
            if (head == null)
            {
                head = newItem;
                return;
            }
            newItem.Next = head;
            head = newItem;
        }
        //Method to add an item at the end
        public void AddItemAtEnd(int id, string name, int quantity, double price)
        {
            Item newItem = new Item(id, name, quantity, price);
            if (head == null)
            {
                head = newItem;
                return;
            }
            Item temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = newItem;
        }
        //Method to add an item at the given position
        public void AddItemAtPosition(int id, string name, int quantity, double price, int position)
        {
            int count = 1;
            Item newItem = new Item(id, name, quantity, price);
            Item temp = head;
            if (head == null)
            {
                head = newItem;
            }
            while (count < position)
            {
                temp = temp.Next;
                count++;
            }
            Item prev = temp;
            temp = temp.Next;
            prev.Next = newItem;
            newItem.Next = temp;
        }
        //Method to remove an item from the list based on Item ID
        public void RemoveItem(int id)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            Item temp = head;
            while (temp.Next.Id != id)
            {
                temp = temp.Next;
            }
            if (temp == null)
            {
                Console.WriteLine("Item is not in the list");
                return;
            }
            temp.Next = temp.Next.Next;
        }
        // Method to update the item quantity by item ID
        public void UpdateQuantity(int id)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            Item temp = head;
            while (temp.Id != id)
            {
                temp = temp.Next;
            }
            if (temp == null)
            {
                Console.WriteLine("Id not fount in List");
                return;
            }
            Console.WriteLine("Enter the new Quantity: ");
            int newQuantity = Convert.ToInt32(Console.ReadLine());
            temp.Id = newQuantity;
        }
        //Method to search Item by Id
        public void SearchById(int id)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            Item temp = head;
            while (temp.Id != id)
            {
                temp = temp.Next;
            }
            if (temp == null)
            {
                Console.WriteLine("the item is not present");
                return;
            }
            Console.WriteLine($"Item ID: {temp.Id}");
            Console.WriteLine($"Name: {temp.Name}");
            Console.WriteLine($"Quantity: {temp.Quantity}");
            Console.WriteLine($"Price: {temp.Price}");
        }
        //Method to search Item by Name
        public void SearchByName(string name)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            Item temp = head;
            while (temp.Name != name)
            {
                temp = temp.Next;
            }
            if (temp == null)
            {
                Console.WriteLine("the item is not present");
                return;
            }
            Console.WriteLine($"Item ID: {temp.Id}");
            Console.WriteLine($"Name: {temp.Name}");
            Console.WriteLine($"Quantity: {temp.Quantity}");
            Console.WriteLine($"Price: {temp.Price}");
        }
        //Method to calculate the total value of inventory
        public void TotalPrice()
        {
            Item temp = head;
            double priceSum = 0;
            while (temp.Next != null)
            {
                priceSum += temp.Price * temp.Quantity;
                temp = temp.Next;
            }
            Console.WriteLine($"Total Price of the Inventory is: {priceSum}");
        }
        // Method to sort the list by price or name
        public void SortInventory(bool byName, bool ascending)
        {
            if (head == null || head.Next == null)
            {
                return;
            }
            Item temp = head;
            bool swapped;
            do
            {
                swapped = false;
                bool condition = byName ? string.Compare(temp.Name, temp.Next.Name) > 0 : temp.Price > temp.Next.Price;
                if (!ascending)
                {
                    condition = !condition;
                }
                if (condition)
                {
                    string tempName = temp.Name;
                    int tempId = temp.Id;
                    int tempQuantity = temp.Quantity;
                    double tempPrice = temp.Price;

                    temp.Price = temp.Next.Price;
                    temp.Quantity = temp.Next.Quantity;
                    temp.Name = temp.Next.Name;
                    temp.Id = temp.Next.Id;

                    temp.Next.Id = tempId;
                    temp.Next.Price = tempPrice;
                    temp.Next.Quantity = tempQuantity;
                    temp.Next.Name = tempName;

                    swapped = true;
                }
                temp = temp.Next;

            } while (swapped);
        }
        //Method to display Inventory
        public void DisplayInventory()
        {
            Item current = head;
            while (current != null)
            {
                Console.WriteLine($"ID: {current.Id}, Name: {current.Name}, Quantity: {current.Quantity}, Price: {current.Price}");
                current = current.Next;
            }
        }
    }
    internal class Program4
    {
        public static void Main(string[] args)
        {
            Inventory inventory = new Inventory();
            inventory.AddItemAtBeginning(101, "Keyboard", 3, 1500);
            inventory.AddItemAtEnd(102, "Mouse", 10, 500);
            inventory.AddItemAtPosition(103, "Mixer", 7, 1000, 2);

            Console.WriteLine("Initial Inventory:");
            inventory.DisplayInventory();

            inventory.UpdateQuantity(102);
            Console.WriteLine("\nAfter Updating Quantity:");
            inventory.DisplayInventory();

            inventory.RemoveItem(103);
            Console.WriteLine("\nAfter Removing an Item:");
            inventory.DisplayInventory();
            inventory.TotalPrice();
            inventory.SortInventory(byName: false, ascending: false);
            Console.WriteLine("\nSorted Inventory by Price Descending:");
            inventory.DisplayInventory();
        }

    }
}
