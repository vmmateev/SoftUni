using System;

namespace _07_VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string start = "";
            double totalMoney = 0;
            while ((start = Console.ReadLine()) != "Start")
            {
                double moneyCoin = double.Parse(start);
                if (moneyCoin == 2)
                {
                    totalMoney += moneyCoin;
                }
                else if (moneyCoin == 1)
                {
                    totalMoney += moneyCoin;
                }
                else if (moneyCoin == 0.5)
                {
                    totalMoney += moneyCoin;
                }
                else if (moneyCoin == 0.2)
                {
                    totalMoney += moneyCoin;
                }
                else if (moneyCoin == 0.1)
                {
                    totalMoney += moneyCoin;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {moneyCoin}");
                }
            }

            while ((start = Console.ReadLine()) != "End")
            {
                if (start == "Nuts")
                {
                    if (totalMoney >= 2)
                    {
                        totalMoney -= 2;
                        Console.WriteLine($"Purchased { start.ToLower()}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (start == "Water")
                {

                    if (totalMoney >= 0.7)
                    {
                        totalMoney -= 0.7;
                        Console.WriteLine($"Purchased {start.ToLower()}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (start == "Crisps")
                {
                    if (totalMoney >= 1.5)
                    {
                        totalMoney -= 1.5;
                        Console.WriteLine($"Purchased {start.ToLower()}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (start == "Soda")
                {
                    if (totalMoney >= 0.8)
                    {
                        totalMoney -= 0.8;
                        Console.WriteLine($"Purchased {start.ToLower()}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (start == "Coke")
                {
                    if (totalMoney >= 1)
                    {
                        totalMoney -= 1;
                        Console.WriteLine($"Purchased {start.ToLower()}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
            }
            Console.WriteLine($"Change: {totalMoney:f2}");
        }
    }
}
