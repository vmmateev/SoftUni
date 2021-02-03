using System;

namespace _02_ASCIIsumator
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();
            string text = Console.ReadLine();


            int sum = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] > first[0] && text[i] < second[0])
                {
                    sum += text[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
