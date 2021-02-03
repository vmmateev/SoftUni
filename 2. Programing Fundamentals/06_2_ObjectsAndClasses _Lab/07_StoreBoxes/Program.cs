using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace _07_StoreBoxes
{
    class Program
    {
        static void Main(string[] args)
        {
            var boxes = new List<Box>();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] tokens = input.Split();
                var item = new Item(tokens[1], double.Parse(tokens[3]));
                var box = new Box(tokens[0], item, int.Parse(tokens[2]), double.Parse(tokens[3]));
                boxes.Add(box);
            }

            foreach (var box in boxes.OrderByDescending(x => x.ItemPrice * x.ItemQuantity))
            {
                Console.WriteLine(box.ToString());
            }
        }
    }

    public class Item
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Item(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }
    }
    public class Box
    {
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public double ItemPrice { get; set; }

        public Box(string serialNumber, Item item, int itemQuantitiy, double itemPrice)
        {
            this.SerialNumber = serialNumber;
            Item = item;
            this.ItemQuantity = itemQuantitiy;
            this.ItemPrice = itemPrice;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(SerialNumber);
            sb.AppendLine($"-- {Item.Name} - ${ItemPrice:f2}: {ItemQuantity}");
            sb.AppendLine($"-- ${(ItemQuantity * ItemPrice):f2}");
            return sb.ToString().TrimEnd();
        }
    }
}
