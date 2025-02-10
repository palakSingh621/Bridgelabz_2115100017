using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_13_Encapsulation
{
    interface IReservable
    {
        void ReserveItem();
        void CheckAvailability();
    }

    internal abstract class LibraryItem
    {
        //Attributes
        private string itemId;
        private string title;
        private string author;
        protected bool isReserved;

        //properties for encapsulation
        public string ItemId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }

        //Constructor
        public LibraryItem(string itemId, string title, string author)
        {
            ItemId = itemId;
            Title = title;
            Author = author;
            isReserved = false;
        }

        //abstract method to get loan duration
        public abstract int GetLoanDuration();

        //concrete method to get item details
        public void GetItemDetails()
        {
            Console.WriteLine("Item ID " + ItemId);
            Console.WriteLine("Title " + Title);
            Console.WriteLine("Author " + Author);
        }
    }

    class Book : LibraryItem, IReservable
    {
        public Book(string itemId, string title, string author) : base(itemId, title, author) { }

        public override int GetLoanDuration()
        {
            int duration = 14; //loan duration for a book is 14 days
            Console.WriteLine("The loan duration for the book " + Title + " is " + duration + " days");
            return duration;
        }

        public void ReserveItem()
        {
            if (!isReserved)
            {
                isReserved = true;
                Console.WriteLine("The book " + Title + " has been reserved");
            }
            else
            {
                Console.WriteLine("The book " + Title + " is already reserved");
            }
        }

        public void CheckAvailability()
        {
            if (isReserved)
            {
                Console.WriteLine("The book is not available");
            }
            else
            {
                Console.WriteLine("The book is available");
            }
        }
    }

    class Magazine : LibraryItem, IReservable
    {
        public Magazine(string itemId, string title, string author) : base(itemId, title, author) { }

        public override int GetLoanDuration()
        {
            int duration = 7; //loan duration for magazines is 10 days
            Console.WriteLine("The loan duration for the magazine " + Title + " is " + duration + " days.");
            return duration;
        }

        public void ReserveItem()
        {
            if (!isReserved)
            {
                isReserved = true;
                Console.WriteLine("The magazine " + Title + " has been reserved.");
            }
            else
            {
                Console.WriteLine("The magazine " + Title + " is already reserved.");
            }
        }

        public void CheckAvailability()
        {
            if (isReserved)
            {
                Console.WriteLine("The magazine is not available");
            }
            else
            {
                Console.WriteLine("The magazine is available");
            }
        }
    }

    class DVD : LibraryItem, IReservable
    {
        public DVD(string itemId, string title, string author) : base(itemId, title, author) { }

        public override int GetLoanDuration()
        {
            int duration = 5; //loan duration for DVDs is 5 days
            Console.WriteLine("The loan duration for the DVD " + Title + " is " + duration + " days.");
            return duration;
        }

        public void ReserveItem()
        {
            if (!isReserved)
            {
                isReserved = true;
                Console.WriteLine("The DVD " + Title + " has been reserved.");
            }
            else
            {
                Console.WriteLine("The DVD " + Title + " is already reserved.");
            }
        }

        public void CheckAvailability()
        {
            if (isReserved)
            {
                Console.WriteLine("The DVD is not available");
            }
            else
            {
                Console.WriteLine("The DVD is available");
            }
        }
    }

    class program5
    {
        public static void Main(string[] args)
        {
            List<LibraryItem> libraryItems = new List<LibraryItem>
            {
                new Book("B101", "A book ", "James"),
                new Magazine("M202", "Vogue", "Stephen"),
                new DVD("D303", "Dexter", "Michael Cuesta")
            };

            foreach (LibraryItem item in libraryItems)
            {
                item.GetItemDetails();
                item.GetLoanDuration();

                if (item is IReservable reservableItem)
                {
                    reservableItem.CheckAvailability();
                    reservableItem.ReserveItem();
                    reservableItem.CheckAvailability();
                }

                Console.WriteLine();
            }
        }
    }
}
