using System;

namespace _03_Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            double totalCourses = Math.Ceiling((double)peopleCount / capacity);
            Console.WriteLine(totalCourses);
        }
    }
}
