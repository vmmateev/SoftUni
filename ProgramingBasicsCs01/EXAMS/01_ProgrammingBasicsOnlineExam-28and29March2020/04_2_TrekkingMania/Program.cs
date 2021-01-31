using System;

namespace _04_2_TrekkingMania
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupsCount = int.Parse(Console.ReadLine());
            double totalMan = 0;

            double musalaCount = 0;
            double monblanCount = 0;
            double kilimandjaroCount = 0;
            double k2Count = 0;
            double everestCount = 0;
            for (int i = 1; i <= groupsCount; i++)
            {
                int manCount = int.Parse(Console.ReadLine());
                totalMan += manCount;
                if (manCount <= 5)
                {
                    musalaCount += manCount;
                }
                else if (manCount >= 6 && manCount <= 12)
                {
                    monblanCount += manCount;
                }
                else if (manCount >= 13 && manCount <= 25)
                {
                    kilimandjaroCount += manCount;
                }
                else if (manCount >= 26 && manCount <= 40)
                {
                    k2Count += manCount;
                }
                else if (manCount >= 41)
                {
                    everestCount += manCount;
                }
            }
            Console.WriteLine($"{((musalaCount / totalMan) * 100):f2}%");
            Console.WriteLine($"{((monblanCount / totalMan) * 100):f2}%");
            Console.WriteLine($"{((kilimandjaroCount / totalMan) * 100):f2}%");
            Console.WriteLine($"{((k2Count / totalMan) * 100):f2}%");
            Console.WriteLine($"{((everestCount / totalMan) * 100):f2}%");
        }
    }
}
