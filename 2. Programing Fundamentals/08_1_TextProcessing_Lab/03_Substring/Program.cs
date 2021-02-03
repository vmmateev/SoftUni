using System;

namespace _03_Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string keyToRemove = Console.ReadLine().ToLower();
            string text = Console.ReadLine();

            while (text.Contains(keyToRemove))
            {
                int startIndex = text.IndexOf(keyToRemove);
                text = text.Remove(startIndex, keyToRemove.Length);
            }
            Console.WriteLine(text);
        }
    }
}
