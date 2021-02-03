using System;

namespace _08_BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            double biggestVolume = 0;
            string bigestModel = "";
            for (int i = 0; i < number; i++)
            {
                string kegModel = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                double volume = Math.PI * (radius * radius) * height;
                if (volume > biggestVolume)
                {
                    biggestVolume = volume;
                    bigestModel = kegModel;
                }
            }
            Console.WriteLine(bigestModel);
        }
    }
}
