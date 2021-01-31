using System;

namespace _03_Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            double countCargo = double.Parse(Console.ReadLine());

            double totalCargo = 0;
            double busCargo = 0;
            double truckCargo = 0;
            double trainCargo = 0;
            double busLoadCount = 0;
            double truckLoadCount = 0;
            double trainLoadCount = 0;
            for (int i = 0; i < countCargo; i++)
            {
                double cargo = double.Parse(Console.ReadLine());
                if (cargo <= 3)
                {
                    busCargo += cargo * 200;
                    busLoadCount += cargo;
                }
                else if (cargo >= 4 && cargo <= 11)
                {
                    truckCargo += cargo * 175;
                    truckLoadCount += cargo;
                }
                else if (cargo >= 12)
                {
                    trainCargo += cargo * 120;
                    trainLoadCount += cargo;
                }
                totalCargo += cargo;
            }
            Console.WriteLine($"{(busCargo + truckCargo + trainCargo) / totalCargo:f2}");
            Console.WriteLine($"{busLoadCount / totalCargo * 100:f2}%");
            Console.WriteLine($"{truckLoadCount / totalCargo * 100:f2}%");
            Console.WriteLine($"{trainLoadCount / totalCargo * 100:f2}%");
        }
    }
}
