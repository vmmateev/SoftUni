using System;

namespace _06_Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            double monthsCount = double.Parse(Console.ReadLine());
            double electricityBill = 0;
            double electricityMontly = 0;
            double waterBill = 0;
            double internetBill = 0;
            double otherBill = 0;
            for (int i = 0; i < monthsCount; i++)
            {
                electricityMontly = double.Parse(Console.ReadLine());
                electricityBill += electricityMontly;
                waterBill += 20;
                internetBill += 15;
                double currentOtherBill = electricityMontly + 20 + 15;
                otherBill += currentOtherBill + (currentOtherBill*0.2);
                
            }
            double averageBill = electricityBill + waterBill + internetBill + otherBill;
            Console.WriteLine($"Electricity: {electricityBill:f2} lv");
            Console.WriteLine($"Water: {waterBill:f2} lv");
            Console.WriteLine($"Internet: {internetBill:f2} lv");
            Console.WriteLine($"Other: {otherBill:f2} lv");
            Console.WriteLine($"Average: {(averageBill / monthsCount):f2} lv");
        }
    }
}
