using System;

namespace _09_CharsToString
{
    class Program
    {
        static void Main(string[] args)
        {
            string print = "";
            for (int i = 0; i < 3; i++)
            {
                string input = Console.ReadLine();
                print += input;
            }
            Console.WriteLine(print);
        }
    }
}
