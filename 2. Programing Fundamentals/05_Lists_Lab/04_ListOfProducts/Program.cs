using System;
using System.Collections.Generic;

namespace _04_ListOfProducts
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            List<string> products = new List<string>();

            string newProduct = "";
            for (int i = 0; i < number; i++)
            {
                newProduct = Console.ReadLine();
                products.Add(newProduct);
            }
            products.Sort();
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"{i+1}.{products[i]}");
            }
        }
    }
}
