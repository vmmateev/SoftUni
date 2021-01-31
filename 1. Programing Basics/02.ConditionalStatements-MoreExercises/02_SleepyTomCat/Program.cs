using System;

namespace _02_SleepyTomCat
{
    class Program
    {
        static void Main(string[] args)
        {
            double restDays = double.Parse(Console.ReadLine());

            double workDays = 365 - restDays;

            double timePlayRest = restDays * 127;
            double timePlayWork = workDays * 63;

            double enoughtTimeToPLay = Math.Abs(30000 - (timePlayRest + timePlayWork));

            int hours = (int)enoughtTimeToPLay / 60;
            int minutes = ((int)enoughtTimeToPLay % 60);


            if (timePlayWork + timePlayRest >= 30000)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{hours} hours and {minutes} minutes more for play");
            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hours} hours and {minutes} minutes less for play");
            }
        }
    }
}
