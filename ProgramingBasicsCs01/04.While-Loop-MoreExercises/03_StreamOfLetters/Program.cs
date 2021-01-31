using System;


namespace _03_StreamOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = ""; //Console.ReadLine();
            int cCounter = 0;
            int oCounter = 0;
            int nCounter = 0;
            string message = "";
            string decodedMsg = "";
            while ((command = Console.ReadLine()) != "End")
            {
                char[] symbol = command.ToCharArray();
                if ((symbol[0] > 64 && symbol[0] < 91) || (symbol[0] > 96 && symbol[0] < 123))
                {
                    if (symbol[0] == 'c' || symbol[0] == 'o' || symbol[0] == 'n')
                    {
                        if (symbol[0] == 'c')
                        {
                            cCounter++;
                            if (cCounter > 1)
                            {
                                message += symbol[0];
                            }
                        }
                        if (symbol[0] == 'o')
                        {
                            oCounter++;
                            if (oCounter > 1)
                            {
                                message += symbol[0];
                            }
                        }
                        if (symbol[0] == 'n')
                        {
                            nCounter++;
                            if (nCounter > 1)
                            {
                                message += symbol[0];
                            }
                        }
                    }
                    else
                    {
                        message += symbol[0];
                    }
                    if (cCounter >= 1 && oCounter >= 1 & nCounter >= 1)
                    {
                        message += " ";
                        decodedMsg = message;
                        cCounter = 0;
                        oCounter = 0;
                        nCounter = 0;
                    }
                }
            }
            Console.Write(decodedMsg);
        }
    }
}

