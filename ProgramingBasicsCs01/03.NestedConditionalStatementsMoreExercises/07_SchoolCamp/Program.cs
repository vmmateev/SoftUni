using System;

namespace _07_SchoolCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string groupType = Console.ReadLine();
            double studentCount = double.Parse(Console.ReadLine());
            double nightCount = double.Parse(Console.ReadLine());

            double discount = 1;
            string sportType = "";
            double totalPrice = 0;
            double pricePerNight = 0;

            if (season == "Winter" && (groupType == "boys" || groupType == "girls"))
            {
                pricePerNight = 9.6;
                if (groupType == "girls")
                {
                    sportType = "Gymnastics";
                }
                else if (groupType == "boys")
                {
                    sportType = "Judo";
                }
            }
            else if (season == "Winter" && groupType == "mixed")
            {
                pricePerNight = 10;
                sportType = "Ski";
            }

            else if (season == "Spring" && (groupType == "boys" || groupType == "girls"))
            {
                pricePerNight = 7.2;
                if (groupType == "girls")
                {
                    sportType = "Athletics";
                }
                else if (groupType == "boys")
                {
                    sportType = "Tennis";
                }
            }
            else if (season == "Spring" && groupType == "mixed")
            {
                pricePerNight = 9.5;
                sportType = "Cycling";
            }

            else if (season == "Summer" && (groupType == "boys" || groupType == "girls"))
            {
                pricePerNight = 15;
                if (groupType == "girls")
                {
                    sportType = "Volleyball";
                }
                else if (groupType == "boys")
                {
                    sportType = "Football";
                }
            }
            else if (season == "Summer" && groupType == "mixed")
            {
                pricePerNight = 20;
                sportType = "Swimming";
            }
            if (studentCount >= 50)
            {
                discount = 0.5;
            }
            else if (studentCount >= 20 && studentCount < 50)
            {
                discount = 0.85;
            }
            else if (studentCount >= 10 && studentCount < 20)
            {
                discount = 0.95;
            }

            totalPrice = nightCount * pricePerNight * studentCount * discount;
            Console.WriteLine($"{sportType} {totalPrice:f2} lv.");
        }
    }
}
