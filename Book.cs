using System;
namespace Assignment_10
{
    internal class Book
    {
        static string LibraryName = "Flora Readings";
        string title;
        string author;
        readonly int ISBN;
        public static void DisplayLibraryName()
        {
            Console.WriteLine("Library: " + LibraryName);
        }
        public Book(string title, string author, int ISBN)
        {
            this.title = title;
            this.author = author;
            this.ISBN = ISBN;
        }
        public void DisplayBooks()
        {
            if (this is Book)
            {
                Console.WriteLine("Title: " + title);
                Console.WriteLine("Author: " + author);
                Console.WriteLine("ISBN: " + ISBN);
            }
            else
            {
                Console.WriteLine("Invalid account object");
            }
        }
    }
    class Program2
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Becoming", "Michelle Obama", 76543);
            Book book2 = new Book("Half Girlfriend", "Chetan Bhagat", 98765);
            Book.DisplayLibraryName();
            Console.WriteLine();
            book1.DisplayBooks();
            Console.WriteLine();
            book2.DisplayBooks();
        }
    }
}
