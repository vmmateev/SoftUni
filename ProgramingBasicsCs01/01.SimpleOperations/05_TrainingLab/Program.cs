using System;

namespace _05_TrainingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            width *= 100;
            height = (height*100)-100;
            
            int workAreaHeight = (int)height/ 70;
            int workAreaWidth = (int)width / 120;

            int seatCount = (workAreaHeight * workAreaWidth) - 3;
            Console.WriteLine(seatCount);
        }
    }
}
