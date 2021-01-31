using System;

namespace _06_WeddingSeats
{
    class Program
    {
        static void Main(string[] args)
        {
            char sector = char.Parse(Console.ReadLine());
            int rowInSector = int.Parse(Console.ReadLine());
            int seatsInOddRow = int.Parse(Console.ReadLine());
            char seatForPrint = 'a';
            int seatCounter = 0;
            for (char i = 'A'; i <= sector; i++)
            {
                for (int j = 1; j <= rowInSector; j++)
                {
                    if (j % 2 == 0)
                    {
                        for (int k = 1; k <= seatsInOddRow + 2; k++)
                        {
                            Console.WriteLine($"{i}{j}{seatForPrint}");
                            seatForPrint++;
                            seatCounter++;
                        }
                    }
                    else
                    {
                        for (int k = 1; k <= seatsInOddRow; k++)
                        {
                            Console.WriteLine($"{i}{j}{seatForPrint}");
                            seatForPrint++;
                            seatCounter++;
                        }
                    }
                    seatForPrint = 'a';
                }
                rowInSector++;
            }
            Console.WriteLine(seatCounter);
        }
    }
}

