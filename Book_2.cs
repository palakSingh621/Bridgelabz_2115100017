using System;
namespace Constructors_Assignment
{
    internal class Book_2
    {
        //Attributes
        public int ISBN;
        protected string title;
        private string author;
        //Constructor
        public Book_2(int ISBN, string title, string author)
        {
            this.ISBN = ISBN;
            this.title = title;
            this.author = author;
        }
        //setter for author
        public void setAuthor()
        {
            Console.Write("Enter the new Author: ");
            author = Convert.ToString(Console.ReadLine());
        }
        //getter for author
        public string getAuthor()
        {
            return author;
        }
        //displaying the data
        public virtual void DisplayDetails()
        {
            Console.WriteLine("ISBN: " + ISBN);
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Author: " + author);
        }
    }
    class EBook : Book_2
    {
        public EBook(int ISBN, string title, string author) : base(ISBN, title, author)
        {
        }
        public void updateISBN()
        {
            Console.Write("Enter the new ISBN: ");
            ISBN = Convert.ToInt32(Console.ReadLine());
        }
        public void updateTitle()
        {
            Console.Write("Enter the new title: ");
            title = Console.ReadLine();
        }
        public override void DisplayDetails()
        {
            base.DisplayDetails();
        }
    }

    class program12
    {
        public static void Main(String[] args)
        {
            Book_2 book1 = new Book_2(123456, "Becoming", "Michell Obama");
            book1.DisplayDetails();
            Console.WriteLine();
            book1.setAuthor();
            book1.DisplayDetails();
            Console.WriteLine();
            EBook ebook1 = new EBook(789342, "Half Girlfriend", "Chetan Bhagat");
            ebook1.DisplayDetails();
            Console.WriteLine();
            ebook1.updateISBN(); //accessing through sub class
            ebook1.DisplayDetails();
            Console.WriteLine();
            ebook1.updateTitle(); //accessing through sub class
            ebook1.DisplayDetails();
        }
    }
}


