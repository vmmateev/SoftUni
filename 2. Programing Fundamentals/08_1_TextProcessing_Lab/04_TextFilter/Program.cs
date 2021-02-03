using System;

namespace _04_TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] splitter = { ',', ' ' };
            string[] banWords = Console.ReadLine().Split(splitter, StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();
            foreach (var banWord in banWords)
            {
                text = text.Replace(banWord, new string('*', banWord.Length));
            }
            Console.WriteLine(text);
        }
    }
}
