using System;
using System.Collections.Generic;
namespace Assignment_19_Generics
{
    internal abstract class WarehouseItem
    {
        //Attributes
        public string Name { get; set; }
        public int Id { get; set; }

        //Constructor
        public WarehouseItem(string name, int id)
        {
            Name = name;
            Id = id;
        }

        //Abstract method to display items
        public abstract void DisplayItem();
    }

    //Electronics class 
    class Electronics : WarehouseItem
    {
        public Electronics(string Name, int Id) : base(Name, Id) { }

        public override void DisplayItem()
        {
            Console.WriteLine("The Electronic item is " + Name + " and it's Id is " + Id);
        }
    }

    class Groceries : WarehouseItem
    {
        public Groceries(string Name, int Id) : base(Name, Id) { }

        public override void DisplayItem()
        {
            Console.WriteLine("The Grocery item is " + Name + " and it's Id is " + Id);
        }
    }

    class Furniture : WarehouseItem
    {
        public Furniture(string Name, int Id) : base(Name, Id) { }

        public override void DisplayItem()
        {
            Console.WriteLine("The Furniture item is " + Name + " and it's Id is " + Id);
        }
    }

    class Storage<T> where T : WarehouseItem
    {
        List<T> list = new List<T>();

        public void AddItem(T item)
        {
            list.Add(item);
        }

        public void DisplayItem()
        {
            foreach (var item in list)
            {
                item.DisplayItem();
            }
        }
    }

    class program1
    {
        public static void Main(String[] args)
        {
            Storage<Electronics> electronics = new Storage<Electronics>();
            electronics.AddItem(new Electronics("Earphones", 1));
            electronics.AddItem(new Electronics("Smart Phone", 2));
            electronics.AddItem(new Electronics("Speaker", 3));

            Storage<Groceries> grocery = new Storage<Groceries>();
            grocery.AddItem(new Groceries("Flour", 4));
            grocery.AddItem(new Groceries("Biscuits", 5));
            grocery.AddItem(new Groceries("Sugar", 6));

            Storage<Furniture> furniture = new Storage<Furniture>();
            furniture.AddItem(new Furniture("Chair", 7));
            furniture.AddItem(new Furniture("Couch", 8));
            furniture.AddItem(new Furniture("Table", 9));

            electronics.DisplayItem();
            grocery.DisplayItem();
            furniture.DisplayItem();
        }
    }
}
