using System;
using System.Numerics;
namespace _04_CenturiesToMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            decimal years = input * 100M;
            decimal days = (int)(years * 365.2422M);
            decimal hours = days * 24;
            decimal minutes = hours * 60;
            Console.WriteLine($"{input} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
            
        }
    }
}
