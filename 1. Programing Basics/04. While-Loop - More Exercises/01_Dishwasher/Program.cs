using System;

namespace _01_Dishwasher
{
    class Program
    {
        static void Main(string[] args)
        {
            double detergent = double.Parse(Console.ReadLine());
            detergent *= 750;
            int count = 0;
            string command = "";
            int potsCounter = 0;
            int dishesCounter = 0;
            while ((command = Console.ReadLine()) != "End")
            {
                count++;
                int dishes = int.Parse(command);
                if (count % 3 == 0)
                {
                    detergent -= (dishes * 15);
                    potsCounter += dishes;
                }
                else
                {
                    detergent -= (dishes * 5);
                    dishesCounter += dishes;
                }
                if (detergent < 0)
                {
                    Console.WriteLine($"Not enough detergent, {Math.Abs(detergent)} ml. more necessary!");
                    break;
                }
            }
            if (detergent >= 0)
            {
                Console.WriteLine("Detergent was enough!");
                Console.WriteLine($"{dishesCounter} dishes and {potsCounter} pots were washed.");
                Console.WriteLine($"Leftover detergent {detergent} ml.");
            }
        }
    }
}
