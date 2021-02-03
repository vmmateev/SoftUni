using System;

namespace _10_Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double headsetTrash = 0;
            double mouseTrash = 0;
            double keyboardTrash = 0;
            double displayTrash = 0;
            for (int i = 1; i <= lostGamesCount; i++)
            {
                if (i % 2 == 0)
                {
                    headsetTrash += 1;
                }
                if (i % 3 == 0)
                {
                    mouseTrash += 1;
                }
                if (i % 6 == 0)
                {
                    keyboardTrash += 1;
                }
                if (i % 12 == 0)
                {
                    displayTrash += 1;
                }
            }
            double totalExpense = (headsetPrice * headsetTrash) + (mousePrice * mouseTrash) + (keyboardPrice * keyboardTrash) + (displayPrice * displayTrash);
            Console.WriteLine($"Rage expenses: {totalExpense:f2} lv.");
        }
    }
}
