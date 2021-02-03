using System;

namespace _05_DecryptingMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int num = int.Parse(Console.ReadLine());
            string message = "";
            for (int i = 0; i < num; i++)
            {
                char symbol = char.Parse(Console.ReadLine());
                int letter = symbol + key;
                message += (char)letter;
            }
            Console.WriteLine(message);
        }
    }
}
