using System;

namespace _03_ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
           string[] input = Console.ReadLine().Split("\\");

            string[] output = input[input.Length - 1].Split(".");
            string fileName = output[0];
            string extension = output[1];
            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}
