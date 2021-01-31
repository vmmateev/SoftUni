using System;

namespace _01_BackToThePast
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());

            double counter = Math.Abs(1800 - year);
            for (int i = 0; i <= counter; i++)
            {
                if (i % 2 != 0)
                {
                    money = money - (12000 + (50 * (i + 18)));
                }
                else
                {
                    money -= 12000;
                }
            }
            if (money >= 0)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {money:f2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {Math.Abs(money):f2} dollars to survive.");
            }
        }
    }
}
