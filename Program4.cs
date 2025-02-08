using System;
namespace Assignment_12_Inheritance
{
    internal class Books
    {
        //Attributes
        private string Title { get; set; }
        private int PublicationYear { get; set; }
        //Constructor
        public Books(string title, int publicationYear)
        {
            Title = title;
            PublicationYear = publicationYear;
        }
        //display details method
        public virtual void DisplayDetails()
        {
            Console.WriteLine("The title of the book is " + Title);
            Console.WriteLine("The publication year of the book is " + PublicationYear);
        }
    }
    class Author : Books
    {
        //Attributes
        private string Name { get; set; }
        private string Bio { get; set; }
        //Constructor
        public Author(string Title, int PublicationYear, string name, string bio) : base(Title, PublicationYear)
        {
            Name = name;
            Bio = bio;
        }
        //method to display details
        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("The name of the author of the book is " + Name);
            Console.WriteLine("Bio of author: " + Bio);
        }
    }
    internal class Program4
    {
        //public static void Main(String[] args)
        //{
        //    Books book1 = new Books("Book title", 1977);
        //    book1.DisplayDetails();
        //    Author author1 = new Author("Book by author", 2000, "Arthur Jr", "Bio of the author here");
        //    author1.DisplayDetails();
        //}
    }
}
