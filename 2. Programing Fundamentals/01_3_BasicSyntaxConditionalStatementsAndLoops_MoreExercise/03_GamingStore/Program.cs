using System;
using System.ComponentModel;

namespace _03_GamingStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string gameName = "";
            double totalSpent = 0;
            while ((gameName = Console.ReadLine()) != "Game Time")
            {
                if (gameName == "OutFall 4" || gameName == "RoverWatch Origins Edition")
                {
                    if (budget >= 39.99)
                    {
                        budget -= 39.99;
                        totalSpent += 39.99;
                        Console.WriteLine($"Bought {gameName}");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (gameName == "CS: OG")
                {
                    if (budget >= 15.99)
                    {
                        budget -= 15.99;
                        totalSpent += 15.99;
                        Console.WriteLine($"Bought {gameName}");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (gameName == "Zplinter Zell")
                {
                    if (budget >= 19.99)
                    {
                        budget -= 19.99;
                        totalSpent += 19.99;
                        Console.WriteLine($"Bought {gameName}");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (gameName == "Honored 2")
                {
                    if (budget >= 59.99)
                    {
                        budget -= 59.99;
                        totalSpent += 59.99;
                        Console.WriteLine($"Bought {gameName}");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (gameName == "RoverWatch")
                {
                    if (budget >= 29.99)
                    {
                        budget -= 29.99;
                        totalSpent += 29.99;
                        Console.WriteLine($"Bought {gameName}");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else
                {
                    Console.WriteLine("Not Found");
                }
                if (budget <= 0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }
            }
            if (budget > 0)
            {
                Console.WriteLine($"Total spent: ${totalSpent:f2}. Remaining: ${budget:f2}");
            }
        }
    }
}
