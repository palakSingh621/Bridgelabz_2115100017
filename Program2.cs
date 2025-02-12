using System;
namespace Assignment_14_LinkedList
{
    class Movie
    {
        public string Title { get; set; }
        public string Director { get; set; }
        public int YearOfRelease { get; set; }
        public double Rating { get; set; }
        public Movie Next { get; set; }
        public Movie Prev { get; set; }
        public Movie(string title, string director, int yearOfRelease, double rating)
        {
            Title = title;
            Director = director;
            YearOfRelease = yearOfRelease;
            Rating = rating;
            Next = null;
            Prev = null;
        }
        public override string ToString()
        {
            return $"Title: {Title}, Director: {Director}, Year: {YearOfRelease}, Rating: {Rating}";
        }
    }
    class MovieDoublyLinkedList
    {
        private Movie head;
        private Movie tail;
        public MovieDoublyLinkedList()
        {
            head = null;
            tail = null;
        }
        // Add at the beginning
        public void AddAtBeginning(Movie newMovie)
        {
            if (head == null)
            {
                head = tail = newMovie;
            }
            else
            {
                newMovie.Next = head;
                head.Prev = newMovie;
                head = newMovie;
            }
        }
        // Add at the end
        public void AddAtEnd(Movie newMovie)
        {
            if (head == null)
            {
                head = tail = newMovie;
            }
            else
            {
                tail.Next = newMovie;
                newMovie.Prev = tail;
                tail = newMovie;
            }
        }
        // Add at a specific position
        public void AddAtPosition(Movie newMovie, int position)
        {
            if (position == 1)
            {
                AddAtBeginning(newMovie);
                return;
            }
            Movie current = head;
            int count = 1;
            while (current != null && count < position - 1)
            {
                current = current.Next;
                count++;
            }
            if (current == null)
            {
                Console.WriteLine("Position out of range.");
                return;
            }

            newMovie.Next = current.Next;
            newMovie.Prev = current;
            if (current.Next != null)
            {
                current.Next.Prev = newMovie;
            }
            current.Next = newMovie;
        }

        // Remove a movie by Title
        public void RemoveByTitle(string title)
        {
            Movie current = head;

            while (current != null)
            {
                if (current.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                {
                    if (current.Prev != null)
                    {
                        current.Prev.Next = current.Next;
                    }
                    else
                    {
                        head = current.Next;
                    }

                    if (current.Next != null)
                    {
                        current.Next.Prev = current.Prev;
                    }
                    else
                    {
                        tail = current.Prev;
                    }

                    return;
                }
                current = current.Next;
            }

            Console.WriteLine("Movie not found.");
        }

        // Search for a movie by Director or Rating
        public void SearchByDirectorOrRating(string director, double rating)
        {
            Movie current = head;

            while (current != null)
            {
                if (current.Director.Equals(director, StringComparison.OrdinalIgnoreCase) || current.Rating == rating)
                {
                    Console.WriteLine(current);
                }
                current = current.Next;
            }
        }

        // Display all movie records
        public void DisplayAllForward()
        {
            Movie current = head;

            while (current != null)
            {
                Console.WriteLine(current);
                current = current.Next;
            }
        }

        // Display all movie records in reverse order
        public void DisplayAllReverse()
        {
            Movie current = tail;

            while (current != null)
            {
                Console.WriteLine(current);
                current = current.Prev;
            }
        }

        // Update a movie's Rating based on the Movie Title
        public void UpdateRating(string title, double newRating)
        {
            Movie current = head;

            while (current != null)
            {
                if (current.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                {
                    current.Rating = newRating;
                    return;
                }
                current = current.Next;
            }

            Console.WriteLine("Movie not found.");
        }
    }

    class Program2
    {
        static void Main()
        {
            MovieDoublyLinkedList movieList = new MovieDoublyLinkedList();

            movieList.AddAtEnd(new Movie("Inception", "Christopher Nolan", 2010, 8.8));
            movieList.AddAtEnd(new Movie("The Dark Knight", "Christopher Nolan", 2008, 9.0));
            movieList.AddAtEnd(new Movie("Interstellar", "Christopher Nolan", 2014, 8.6));
            Console.WriteLine("All Movie Records (Forward):");
            movieList.DisplayAllForward();
            Console.WriteLine();
            Console.WriteLine("All Movie Records (Reverse):");
            movieList.DisplayAllReverse();
            Console.WriteLine();
            Console.WriteLine("Searching for movies directed by 'Christopher Nolan' or with Rating 8.8:");
            movieList.SearchByDirectorOrRating("Christopher Nolan", 8.8);
            Console.WriteLine();
            Console.WriteLine("Updating rating for 'Inception':");
            movieList.UpdateRating("Inception", 9.2);
            movieList.DisplayAllForward();
            Console.WriteLine();
            Console.WriteLine("Deleting 'The Dark Knight':");
            movieList.RemoveByTitle("The Dark Knight");
            movieList.DisplayAllForward();
            Console.WriteLine();
            Console.WriteLine("Adding 'The Prestige' at the beginning:");
            movieList.AddAtBeginning(new Movie("The Prestige", "Christopher Nolan", 2006, 8.5));
            movieList.DisplayAllForward();
            Console.WriteLine();
        }
    }
}
