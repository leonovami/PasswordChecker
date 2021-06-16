using System;

namespace PasswordChecker
{
    class Program
    {
        public static void Main(string[] args)
        {
            int minLength = 8;
            string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowercase = "abcdefghijklmnopqrstuvwxyz";
            string digits = "0123456789";
            string specialChars = "`~!@#$%^&*()_-+={}[]\\|:;\"'<>,.?/ ";

            Console.WriteLine("Please enter your password:");
            string userPassword = Console.ReadLine();

            int score = 0;

            if (userPassword.Length >= minLength)
            {
                score++;
            }

            if (userPassword.IndexOfAny(uppercase.ToCharArray()) != -1)
            {
                score++;
            }

            if (userPassword.IndexOfAny(lowercase.ToCharArray()) != -1)
            {
                score++;
            }

            if (userPassword.IndexOfAny(digits.ToCharArray()) != -1)
            {
                score++;
            }
            if (userPassword.IndexOfAny(specialChars.ToCharArray()) != -1)
            {
                score++;
            }

            switch (score)
            {
                case 4:
                case 5:
                    Console.WriteLine("Password is extremely strong");
                    break;
                case 3:
                    Console.WriteLine("Password is strong");
                    break;
                case 2:
                    Console.WriteLine("Password is medium");
                    break;
                case 1:
                    Console.WriteLine("Password is weak");
                    break;
            }

            Console.WriteLine("\nPress any key to exit");
            Console.ReadKey();
        }
    }
}