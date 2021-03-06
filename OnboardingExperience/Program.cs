﻿using System;

namespace OnboardingExperience
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User();

            user.IsAccountOwner = AskBoolQuestion("Are you an account owner?");

            if (user.IsAccountOwner)
            {
                Console.WriteLine("you already have an account");
                Console.WriteLine("\n the app will now close");
                return;
            }

            Console.WriteLine("Welcome to Amar Taka, enter your information to setup a new account");

            user.FirstName = AskQuestion("\nEnter your First Name");
            Console.WriteLine($"\nHi {user.FirstName},");

            user.LastName = AskQuestion("What is your last name");
            Console.WriteLine($"\nOk {user.FirstName} {user.LastName}");

            user.PinNumber = IntQuestion("what is your Pin Number");

            Console.WriteLine($"{user.PinNumber} Great save your pin and don't share it with anybody");
            Console.ReadKey(true);
        }

        public static int IntQuestion(string questionInt)
        {
            Console.WriteLine(questionInt);
            int num;

            // Execute while not a number
            while (!int.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("**ERROR** Invalid input enter valid number");
            }
            return num;
        }

        public static bool AskBoolQuestion(string question)
        {
            while (true)
            {
                var result = AskQuestion(question + " (y/n)");

                if (result.ToLower() == "y") { return true; }
                else if (result.ToLower() == "n") { return false; }

                Console.WriteLine("\nYou must enter y or n");
            }
        }

        static string AskQuestion(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }
    }
}
