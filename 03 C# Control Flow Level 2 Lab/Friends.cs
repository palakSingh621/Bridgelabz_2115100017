using System;
    class Friends
    {
        public static void Main(String[] args)
        {
            // Taking user input for ages and heights
			
            Console.Write("Enter the age of friend A (Amar):");
            int ageFriendA = int.Parse(Console.ReadLine());

            Console.Write("Enter the height of friend A (in cm):");
            int heightFriendA = int.Parse(Console.ReadLine());

            Console.Write("Enter the age of friend B (Akbar):");
            int ageFriendB = int.Parse(Console.ReadLine());

            Console.Write("Enter the height of friend B (in cm):");
            int heightFriendB = int.Parse(Console.ReadLine());

            Console.Write("Enter the age of friend C (Anthony):");
            int ageFriendC = int.Parse(Console.ReadLine());

            Console.Write("Enter the height of friend C (in cm):");
            int heightFriendC = int.Parse(Console.ReadLine());

            // Determining the youngest friend's age
			
            int youngestAge = Math.Min(ageFriendA, Math.Min(ageFriendB, ageFriendC));
            string youngestFriend;
            if (youngestAge == ageFriendA)
            {
                youngestFriend = "Friend A (Amar)";
            }
            else if (youngestAge == ageFriendB)
            {
                youngestFriend = "Friend B (Akbar)";
            }
            else
            {
                youngestFriend = "Friend C (Anthony)";
            }

            // Determining the tallest friend's height
			
            int tallestHeight = Math.Max(heightFriendA, Math.Max(heightFriendB, heightFriendC));
            string tallestFriend;
            if (tallestHeight == heightFriendA)
            {
                tallestFriend = "Friend A (Amar)";
            }
            else if (tallestHeight == heightFriendB)
            {
                tallestFriend = "Friend B (Akbar)";
            }
            else
            {
                tallestFriend = "Friend C (Anthony)";
            }

            // Displaying the results
            Console.WriteLine("The youngest friend is " + youngestFriend + " with age " + youngestAge + " years.");
            Console.WriteLine("The tallest friend is " + tallestFriend + " with height " + tallestHeight + " cm.");
        }
    }
}
