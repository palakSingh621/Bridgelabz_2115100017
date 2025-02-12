using System;
namespace Assignment_14_LinkedList
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int Id { get; set; }
        public bool AvailabilityStatus { get; set; }
        public Book Next;
        public Book Prev;
        public Book(int id, string title, string author, string genre, bool status)
        {
            this.Id = id;
            this.Title = title;
            this.Author = author;
            this.Genre = genre;
            this.AvailabilityStatus = status;
            Next = null;
            Prev = null;
        }
    }
    class Library
    {
        public Book head;
        public Book tail;
        public int bookCount = 0;
        //Method to Add Book at the Beginning of the list
        public void AddBookAtBeginning(int id, string title, string author, string genre, bool status)
        {
            Book newBook = new Book(id, title, author, genre, status);
            if (head == null)
            {
                head = newBook;
                tail = newBook;
            }
            else
            {
                newBook.Next = head;
                head.Prev = newBook;
                head = newBook;
            }
            bookCount++;
        }
        //Method to Add Book at the End of the List
        public void AddBookAtEnd(int id, string title, string author, string genre, bool status)
        {
            Book newBook = new Book(id, title, author, genre, status);
            if (head == null)
            {
                head = newBook;
                tail = newBook;
            }
            else
            {
                tail.Next = newBook;
                newBook.Prev = tail;
                tail = newBook;
            }
            bookCount++;
        }
        //Method to insert book at the given position
        public void AddBookAtPosition(int id, string title, string author, string genre, bool status, int position)
        {
            Book newBook = new Book(id, title, author, genre, status);
            if (head == null)
            {
                head = newBook;
                tail = newBook;
            }
            else
            {
                int count = 1;
                Book temp = head;
                while (count < position)
                {
                    temp = temp.Next;
                    count++;
                }
                Book temp1 = temp.Next;
                temp.Next = newBook;
                newBook.Prev = temp;
                newBook.Next = temp1;
                temp1.Prev = newBook;
            }
            bookCount++;
        }
        //Method to remove a Book by Book ID
        public void RemoveBook(int id)
        {
            if (head == null && tail == null)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                Book temp = head;
                while (temp.Id != id)
                {
                    temp = temp.Next;
                }
                if (temp == null)
                {
                    Console.WriteLine("Book not found.");
                    return;
                }

                if (temp.Prev != null)
                {
                    temp.Prev.Next = temp.Next;
                }
                else
                {
                    head = temp.Next;
                }

                if (temp.Next != null)
                {
                    temp.Next.Prev = temp.Prev;
                }
                else
                {
                    tail = temp.Prev;
                }
                Console.WriteLine("Book removed.");
                bookCount--;
            }
        }
        //Method to search book by title
        public void SearchBookByTitle(string title)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            Book temp = head;
            while (temp.Title != title)
            {
                temp = temp.Next;
            }
            if (temp == null)
            {
                Console.WriteLine("Book not found");
                return;
            }
            Console.WriteLine($"Book ID: {temp.Id}");
            Console.WriteLine($"Title: {temp.Title}");
            Console.WriteLine($"Author: {temp.Author}");
            Console.WriteLine($"Genre: {temp.Genre}");
            Console.WriteLine("Availability Status: " + (temp.AvailabilityStatus ? "In Stock" : "Out of Stock"));
        }
        //Method to search book by author
        public void SearchBookByAuthor(string author)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            Book temp = head;
            while (temp.Author != author)
            {
                temp = temp.Next;
            }
            if (temp == null)
            {
                Console.WriteLine("Book not found");
                return;
            }
            Console.WriteLine($"Book ID: {temp.Id}");
            Console.WriteLine($"Title: {temp.Title}");
            Console.WriteLine($"Author: {temp.Author}");
            Console.WriteLine($"Genre: {temp.Genre}");
            Console.WriteLine("Availability Status: " + (temp.AvailabilityStatus ? "In Stock" : "Out of Stock"));
        }
        //Method to update Availability Status
        public void UpdateStatus(int id)
        {
            Book temp = head;
            while (temp.Id != id)
            {
                temp = temp.Next;
            }
            if (temp == null)
            {
                Console.WriteLine("Book not found");
                return;
            }
            temp.AvailabilityStatus = !temp.AvailabilityStatus;
        }
        public void DisplayBook()
        {
            Book temp = head;
            while (temp.Next != null)
            {
                Console.WriteLine($"Book ID: {temp.Id}");
                Console.WriteLine($"Title: {temp.Title}");
                Console.WriteLine($"Author: {temp.Author}");
                Console.WriteLine($"Genre: {temp.Genre}");
                Console.WriteLine("Availability Status: " + (temp.AvailabilityStatus ? "In Stock" : "Out of Stock"));
                Console.WriteLine();
                temp = temp.Next;
            }
        }
        //Method to display the books in reverse
        public void DisplayBookReverse()
        {
            Book temp = tail;
            while (temp.Prev != null)
            {
                Console.WriteLine($"Book ID: {temp.Id}");
                Console.WriteLine($"Title: {temp.Title}");
                Console.WriteLine($"Author: {temp.Author}");
                Console.WriteLine($"Genre: {temp.Genre}");
                Console.WriteLine("Availability Status: " + (temp.AvailabilityStatus ? "In Stock" : "Out of Stock"));
                Console.WriteLine();
                temp = temp.Prev;
            }
        }
        //Method to dislay the total count of books in the library
        public void BookCount()
        {
            Console.WriteLine("Total Number of Books in Library: " + bookCount);
        }
    }
    internal class Program5
    {
        static void Main()
        {
            Library library = new Library();

            library.AddBookAtEnd(101, "The Great Gatsby", "F. Scott Fitzgerald", "Classic", true);
            library.AddBookAtEnd(102, "To Kill a Mockingbird", "Harper Lee", "Fiction", true);
            library.AddBookAtBeginning(103, "1984", "George Orwell", "Dystopian", true);
            library.AddBookAtPosition(104, "Moby Dick", "Herman Melville", "Adventure", false, 2);

            Console.WriteLine("Books in forward order:");
            library.DisplayBook();

            library.RemoveBook(102);
            Console.WriteLine("After removing book with ID 102:");
            library.DisplayBook();

            library.UpdateStatus(101);
            Console.WriteLine("After updating availability status of book with ID 101:");
            library.DisplayBook();

            Console.WriteLine("Searching for book by title '1984':");
            library.SearchBookByTitle("1984");

            Console.WriteLine("Books in reverse order:");
            library.DisplayBookReverse();

            library.BookCount();
        }

    }
}
