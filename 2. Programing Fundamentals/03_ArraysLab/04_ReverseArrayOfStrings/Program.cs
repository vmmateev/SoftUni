using System;
using System.Linq;

namespace _04_ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split();
            string[] reversedText = new string[text.Length];
            for (int i = 0; i < text.Length; i++)
            {
                reversedText[text.Length-i-1] = text[i];
            }
            for (int i = 0; i < reversedText.Length; i++)
            {
                Console.Write(reversedText[i]+" "); 
            }
        }
    }
}
