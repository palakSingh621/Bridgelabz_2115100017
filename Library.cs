using System;
using System.Collections.Generic;
namespace Assignment_11_OOPs
{
    //Book class to create a book instance independently
    class Book
    {
        string title;
        string author;
        //Constructor
        public Book(string title, string author)
        {
            this.title = title;
            this.author = author;
        }
        // Book details display Method
        public void DisplayBook()
        {
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Author: {author}");
            Console.WriteLine();
        }
    }
    // Library class to aggregate the book object in a library
    class Library
    {
        string libraryName;
        List<Book> books=new List<Book>();
        // constructor
        public Library(string libraryName)
        {
            this.libraryName = libraryName;
        }
        //Method to add an independent book instance to the library
        public void AddBooks(Book book)
        {
            books.Add(book);
        }
        // Method to display list of available books in Library
        public void DisplayLibraryBooks()
        {
            Console.WriteLine($"Library: {libraryName} Book List: ");
            Console.WriteLine();
            foreach(Book book in books)
            {
                book.DisplayBook();
            }
        }
    }
    //Main method class
    internal class Program1
    {
        static void Main(string[] args)
        {
            //Creating book instances
            Book b1 = new Book("Becoming", "Michelle Obama");
            Book b2 = new Book("Think like a monk", "Jay Shetty");
            Book b3 = new Book("The 3 mistakes of my life", "Chetan Bhagat");
            //creating library instances
            Library library_1 = new Library("Pen Pal");
            Library library_2 = new Library("Popular books");
            //Adding books to the library
            library_1.AddBooks(b1);
            library_2.AddBooks(b2);
            library_1.AddBooks(b3);
            library_2.AddBooks(b3);
            // Displaying books in each each library
            library_1.DisplayLibraryBooks();
            library_2.DisplayLibraryBooks();
        }
    }
}
