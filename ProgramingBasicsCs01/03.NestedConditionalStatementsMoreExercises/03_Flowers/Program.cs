using System;

namespace _03_Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            double hrizantema = double.Parse(Console.ReadLine());
            double rose = double.Parse(Console.ReadLine());
            double tulip = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string holiday = Console.ReadLine();

            double chargeHoliday = 1;

            double hrizantemaPrice = 0;
            double rosePrice = 0;
            double tulipPrice = 0;
            if (holiday == "Y")
            {
                chargeHoliday = 1.15;
            }

            if (season == "Spring" || season == "Summer")
            {
                hrizantemaPrice = 2;
                rosePrice = 4.1;
                tulipPrice = 2.5;
            }

            else if (season == "Autumn" || season == "Winter")
            {
                hrizantemaPrice = 3.75;
                rosePrice = 4.5;
                tulipPrice = 4.15;
            }

            double totalSum = ((hrizantema * hrizantemaPrice) + (rose * rosePrice) + (tulip * tulipPrice)) * chargeHoliday;

            if (season == "Spring" && tulip >= 7)
            {
                totalSum -= totalSum * 0.05;
            }
            else if (season == "Winter" && rose >= 10)
            {
                totalSum -= totalSum * 0.1;
            }
            if (hrizantema + rose + tulip >= 20)
            {
                totalSum -= totalSum * 0.2;
            }
            totalSum += 2;
            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
