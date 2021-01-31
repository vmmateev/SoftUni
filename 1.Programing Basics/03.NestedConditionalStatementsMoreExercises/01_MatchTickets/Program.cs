using System;

namespace _01_MatchTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string typeTicket = Console.ReadLine();
            double peopleCount = double.Parse(Console.ReadLine());
            double ticketPrice = 1;
            double transportPrice = 0;

            if (peopleCount >= 1 && peopleCount <= 4)
            {
                transportPrice = budget * 0.75;
            }
            else if (peopleCount >= 5 && peopleCount <= 9)
            {
                transportPrice = budget * 0.6;
            }
            else if (peopleCount >= 10 && peopleCount <= 24)
            {
                transportPrice = budget * 0.5;
            }
            else if (peopleCount >= 25 && peopleCount <= 49)
            {
                transportPrice = budget * 0.4;
            }
            else if (peopleCount >= 50)
            {
                transportPrice = budget * 0.25;
            }
            if (typeTicket == "VIP")
            {
                ticketPrice = 499.99;
            }
            if (typeTicket == "Normal")
            {
                ticketPrice = 249.99;
            }
            double totalSum = (peopleCount * ticketPrice) + transportPrice;
            if (totalSum <= budget)
            {
                Console.WriteLine($"Yes! You have {Math.Abs(totalSum - budget):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(totalSum - budget):f2} leva.");
            }
        }
    }
}
