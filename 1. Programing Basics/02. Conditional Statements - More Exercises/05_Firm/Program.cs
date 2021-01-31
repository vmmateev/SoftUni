using System;

namespace _05_Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            double hoursNeeded = double.Parse(Console.ReadLine());
            double daysAvailable = double.Parse(Console.ReadLine());
            double workersCountOvertime = double.Parse(Console.ReadLine());

            double daysForWork = daysAvailable - (daysAvailable * 0.1);
            double normalWorkHours = daysForWork * 8;
            double overTime = (workersCountOvertime * daysAvailable) * 2;
            double totalTime = Math.Floor(normalWorkHours + overTime);

            if (totalTime >= hoursNeeded)
            {
                Console.WriteLine($"Yes!{Math.Floor(totalTime - hoursNeeded)} hours left.");
            }
            else
            {
                Console.WriteLine($"Not enough time!{Math.Floor(hoursNeeded - totalTime)} hours needed.");
            }
        }
    }
}
