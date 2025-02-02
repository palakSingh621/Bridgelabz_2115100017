using System;
namespace Constructors_Assignment
{
    internal class HotelBooking
    {
        //Attributes
        private string guestName;
        private string roomType;
        private int nights;
        //Constructor
        public HotelBooking(string guestName, string roomType, int nights)
        {
            this.guestName = guestName;
            this.roomType = roomType;
            this.nights = nights;
        }
        //Copy Constructor
        public HotelBooking(HotelBooking booking)
        {
            guestName = booking.guestName;
            roomType = booking.roomType;
            nights = booking.nights;
        }
        //Default Constructor using chaining
        public HotelBooking() : this("No name found", "No room type found", 0)
        {

        }
        //Displaying details
        public void displayDetails()
        {
            Console.WriteLine("The name of the guest: " + guestName);
            Console.WriteLine("The type of the room: " + roomType);
            Console.WriteLine("Number of nights: " + nights);
        }
        static void Main(String[] args)
        {
            HotelBooking booking1 = new HotelBooking("Priya", "Suite", 21);
            booking1.displayDetails();
            Console.WriteLine(" ");
            HotelBooking booking2 = new HotelBooking(booking1); //calling copy constructor
            booking2.displayDetails();
            Console.WriteLine(" ");
            HotelBooking booking3 = new HotelBooking(); //calling default constructor
            booking3.displayDetails();
        }
    }
}
