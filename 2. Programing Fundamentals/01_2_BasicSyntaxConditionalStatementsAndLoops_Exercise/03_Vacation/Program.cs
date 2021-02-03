using System;
using System.Text.RegularExpressions;

namespace _03_Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupCount = int.Parse(Console.ReadLine());
            string typeGroup = Console.ReadLine();
            string day = Console.ReadLine();
            double discount = 1;
            double pricePerNight = 0;
            if (typeGroup == "Students")
            {
                if (groupCount >= 30)
                {
                    discount = 0.85;
                }
                if (day == "Friday")
                {
                    pricePerNight = 8.45;
                }
                else if (day == "Saturday")
                {
                    pricePerNight = 9.80;
                }
                else if (day == "Sunday")
                {
                    pricePerNight = 10.46;
                }
            }
            else if (typeGroup == "Business")
            {
                if (groupCount >= 100)
                {
                    groupCount -= 10;
                }
                if (day == "Friday")
                {
                    pricePerNight = 10.90;
                }
                else if (day == "Saturday")
                {
                    pricePerNight = 15.6;
                }
                else if (day == "Sunday")
                {
                    pricePerNight = 16;
                }
            }
            else if (typeGroup == "Regular")
            {
                if (groupCount >= 10 && groupCount <= 20)
                {
                    discount = 0.95;
                }
                if (day == "Friday")
                {
                    pricePerNight = 15;
                }
                else if (day == "Saturday")
                {
                    pricePerNight = 20;
                }
                else if (day == "Sunday")
                {
                    pricePerNight = 22.5;
                }
            }
            double totalSum = pricePerNight * groupCount * discount;
            Console.WriteLine($"Total price: {totalSum:f2}");

        }
    }
}
