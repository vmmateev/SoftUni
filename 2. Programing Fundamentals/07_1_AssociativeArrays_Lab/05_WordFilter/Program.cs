using System;
using System.Linq;

namespace _05_WordFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split().ToArray();
            foreach (var word in words)
            {
                if (word.Length%2==0)
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}
