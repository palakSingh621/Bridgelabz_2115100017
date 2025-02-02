using System;
namespace Constructors_Assignment
{
    internal class Book
    {
        //Attrbutes
        private string title;
        private string author;
        private int availability;
        private double price;
        //Constructor
        public Book(string title, string author, double price, int availability)
        {
            this.title = title;
            this.author = author;
            this.price = price;
            this.availability = availability;
        }
        //Default Constructor
        public Book()
        {
            title = "Unknown";
            author = "Unknown";
            price = 0.0;
            availability = 0;
        }
        //Borrowing a book
        public void BorrowBook()
        {
            if (availability == 0)
            {
                Console.WriteLine("Sorry, you cannot borrow this book. As they are out of stock.");
            }
            else
            {
                Console.WriteLine("Thanks for borrowing the book!");
                availability--;
            }
        }
        //Displaying the details
        public void DisplayDetails()
        {
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Author: " + author);
            Console.WriteLine("price: " + price);
            Console.WriteLine("Number of remaining books: " + availability);
        }
        static void Main(String[] args)
        {
            Book book1 = new Book("A Song of Ice and Fire", "George R.R. Martin", 780.00, 4);
            Book book2 = new Book();
            book1.DisplayDetails();
            Console.WriteLine(" ");
            book2.DisplayDetails();
            Console.WriteLine(" ");
            book1.BorrowBook();
        }
    }
}
