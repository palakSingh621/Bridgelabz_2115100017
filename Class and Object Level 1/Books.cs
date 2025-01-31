using System;
namespace Object_and_Classes
{
    internal class Books
    {
        private string title;
        private string author;
        private double price;
        //Constructor
        public Books(string title, string author, double price)
        {
            this.title = title;
            this.author = author;
            this.price = price;
        }
        //Method to display the details 
        public void DisplayDetails()
        {
            Console.WriteLine("Title : "+title);
            Console.WriteLine("Author : " + author);
            Console.WriteLine("Price :" + price);
        }

        //Main method 
        static void Main(String[] args)
        {
            Books book1 = new Books("Becoming", "Michell Obama", 3000.00);
            Console.WriteLine("Details of Book 1:");
            book1.DisplayDetails();
            Console.WriteLine();
            Books book2 = new Books("The Palace of illusions", "Chitra Banerjee Divakaruni", 1000.00);
            Console.WriteLine("Details of Book 2:");
            book2.DisplayDetails();

        }
    }
}
