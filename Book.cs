using System;
namespace Constructors_Assignment
{
    internal class Books
    {
        //Attributes
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
        //Default Constructor
        public Books()
        {
            title = "Unknown";
            author = "Unknown";
            price = 0.0;
        }
        //Displaying the details
        public void DisplayDetails()
        {
            Console.WriteLine("The title of the book is " + title);
            Console.WriteLine("The author of the book is " + author);
            Console.WriteLine("The price of the book is " + price);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Books Details: ");
            Book book1 = new Book("A Song of Ice and Fire", "George R.R. Martin", 900.00);
            Book book2 = new Book();
            Console.WriteLine(" ");
            book1.DisplayDetails();
            Console.WriteLine(" ");
            book2.DisplayDetails();
        }
    }
}
