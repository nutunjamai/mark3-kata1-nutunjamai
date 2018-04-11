using System;

namespace OnboardingExperience
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User();
            
            Console.WriteLine("Welcome to Amar Taka, enter your information to setup a new account");
            Console.WriteLine("\nEnter your First Name");
            user.FirstName = Console.ReadLine();
            Console.WriteLine($"\nHi, {user.FirstName} what is your last name");
            Console.WriteLine("\nEnter Last Name");
            user.LastName = Console.ReadLine();
            
            Console.WriteLine($"\nHi, {user.FirstName} {user.LastName} what is your Pin Number");
            
             
            
            user.PinNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{user.PinNumber}");

            Console.ReadKey(true);


        }
    }
}
