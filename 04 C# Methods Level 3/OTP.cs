using System;
class OTP
{
    // Method to generate a 6-digit OTP
    public static int GenerateOTP()
    {
		// Generates a random number between 100000 and 999999
        Random random = new Random();
        return random.Next(100000, 999999); 
    }
    // Method to ensure all generated OTPs are unique
    public static bool AreOTPsUnique(int[] otpArray)
    {
       for(int i=0;i<otpArray.Length-1;i++)
	   {
		   for(int j=i+1;j<otpArray.Length;j++)
		   {
			   if(otpArray[i]==otpArray[j])
			   {
				   return false;
			   }
		   }
	   }
	   return true;
    }
    public static void Main(string[] args)
    {
        int[] otps = new int[10];
        for (int i = 0; i < otps.Length; i++)
        {
            otps[i] = GenerateOTP();
        }
        Console.WriteLine("Generated OTPs:");
        foreach (int otp in otps)
        {
            Console.WriteLine(otp);
        }
        // Check if all OTPs are unique
        if(AreOTPsUnique(otps))
		{
			Console.WriteLine("All OTPs are unique");
		}else{
			Console.WriteLine("OTPs are not unique");
		}			
    }
}
