using System;

namespace _09_PadawanEquipment_bonus
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int studentCount = int.Parse(Console.ReadLine());
            double lightsaberPrice = double.Parse(Console.ReadLine());
            double robesPrice = double.Parse(Console.ReadLine());
            double beltsPrice = double.Parse(Console.ReadLine());
            double freeBelts = 0;
            double lightSabers = (Math.Ceiling(studentCount * 1.10));
            if (studentCount >= 6)
            {
                freeBelts = studentCount / 6;
            }
            double belts = (studentCount - freeBelts);
            double moneyNeeded = ((lightsaberPrice * lightSabers) + (robesPrice * studentCount) + (belts * beltsPrice));
            if (money >= moneyNeeded)
            {
                Console.WriteLine($"The money is enough - it would cost {moneyNeeded:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {(moneyNeeded - money):f2}lv more.");
            }
        }
    }
}
