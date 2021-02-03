using System;

namespace _04_BackIn30Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int min30 = minutes + 30;
            if (min30 >= 60)
            {
                hours += 1;
                min30 -= 60;
            }
            if (hours>23)
            {
                hours = 0;
            }
            if (min30 < 10)
            {
                Console.WriteLine($"{hours}:0{min30}");
            }
            else
            {
                Console.WriteLine($"{hours}:{min30}");
            }
        }
    }
}
