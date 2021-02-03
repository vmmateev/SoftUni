using System;
using System.Diagnostics.Tracing;

namespace _05_Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = "";

            int counter = 0;
            for (int i = username.Length - 1; i >= 0; i--)
            {
                password += username[i];
            }

            string passwordTry = "";
            while ((passwordTry = Console.ReadLine()) != password)
            {
                counter++;
                if (counter > 3)
                {
                    break;
                }
                Console.WriteLine("Incorrect password. Try again.");
            }
            if (counter > 3)
            {
                Console.WriteLine($"User {username} blocked!");
            }
            else
            {
                Console.WriteLine($"User {username} logged in.");
            }
        }
    }
}
