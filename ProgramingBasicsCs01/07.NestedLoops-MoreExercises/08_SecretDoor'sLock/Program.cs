using System;

namespace _08_SecretDoor_sLock
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            for (int stotici = 2; stotici <= first; stotici+=2)
            {
                for (int desetici = 2; desetici <= second; desetici++)
                {
                    for (int edinici = 2; edinici <= third; edinici+=2)
                    {
                        if ((stotici % 2 == 0 && edinici % 2 == 0))
                        {
                            if (desetici == 2 || desetici == 5 || desetici == 7 || desetici == 3)
                            {
                                Console.WriteLine($"{stotici} {desetici} {edinici}");
                            }
                        }
                    }
                }
            }
            //for (int stotici = 2; stotici <= first; stotici += 2)
            //{
            //    for (int desetici = 2; desetici <= second; desetici++)
            //    {

            //        bool isPrime = true;
            //        for (int i = 2; i <= Math.Sqrt(desetici); i++)
            //        {
            //            if (desetici % i == 0 && desetici != 2)
            //            {
            //                isPrime = false;
            //                break;
            //            }
            //        }
            //        for (int edinici = 2; edinici <= third; edinici += 2)
            //        {
            //            if (!isPrime)
            //            {
            //                break;
            //            }
            //            else
            //            {
            //                Console.WriteLine($"{stotici} {desetici} {edinici}");
            //            }
            //        }
            //    }
            //}
        }
    }
}

