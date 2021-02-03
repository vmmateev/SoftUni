using System;
using System.Collections.Generic;
using System.Dynamic;

namespace _04_Orders
{
    class Program
    {
        class Product
        {
            string name { get; set; } // С този тип гетър и сетър няма да можем да сетваме пропъртита по отделно
            double price { get; set; } // Или с други думи ако искаме да редактираме обект добавен към речник по начина 

        }
        class Product2
        {
            string Name;
            double price;

            public string Name2
            {
                get
                {
                    return Name2;
                }
                set 
                {
                    Name2 = value;
                }
            }
        }

        }
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, List<double>>();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "buy")
            {
                string[] commands = input.Split();
                string productName = commands[0];
                double price = double.Parse(commands[1]);
                double quantity = double.Parse(commands[2]);

                if (!dict.ContainsKey(productName))
                {
                    dict.Add(productName, new List<double>() { price, quantity });
                }
                else
                {
                    dict[productName][0] = price;
                    dict[productName][1] += quantity;
                }
            }
            foreach (var product in dict)
            {
                Console.WriteLine($"{product.Key} -> {(product.Value[0] * product.Value[1]):f2}");
            }
            // Три речника
            //var productPrice = new Dictionary<string, double>();
            //var productQuantity = new Dictionary<string, double>();
            //var productPrint = new Dictionary<string, double>();
            //string input = string.Empty;
            //while ((input = Console.ReadLine()) != "buy")
            //{
            //    string[] commands = input.Split();
            //    string productName = commands[0];
            //    double price = double.Parse(commands[1]);
            //    double quantitiy = double.Parse(commands[2]);

            //    if (!productPrice.ContainsKey(productName) && !productQuantity.ContainsKey(productName))
            //    {
            //        productPrice[productName] = price;
            //        productQuantity[productName] = quantitiy;
            //    }
            //    else
            //    {
            //        productPrice[productName] = price;
            //        productQuantity[productName] += quantitiy;
            //    }
            //    productPrint[productName] = productPrice[productName] * productQuantity[productName];
            //}
            //foreach (var item in productPrint)
            //{
            //    Console.WriteLine($"{item.Key} -> {item.Value:f2}");
            //}
        }
    }
}
