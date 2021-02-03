using System;
using System.Linq;
using System.Text;

namespace _03_TreasureFinder
{
    class Program
    {
        static void Main(string[] args)
        {            
            int[] keyList = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var sb = new StringBuilder();

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "find")
            {
                int m = 0;
                for (int k = 0; k < input.Length; k++)
                {
                    sb.Append((char)(input[k] - keyList[m]));
                    m++;
                    if (m == keyList.Length)
                    {
                        m = 0;
                    }
                }
                                
                string decryptedMsg = sb.ToString();
                int metalIndexStart = decryptedMsg.IndexOf('&');
                int metalIndexEnd = decryptedMsg.IndexOf('&', metalIndexStart+1);
                int lenght = metalIndexEnd - metalIndexStart;
                string resource = decryptedMsg.Substring(metalIndexStart+1, lenght-1);
                int coordsIndexStart = decryptedMsg.IndexOf('<');
                int coordsIndexEnd = decryptedMsg.IndexOf('>', coordsIndexStart);
                int coordsLenght = coordsIndexEnd - coordsIndexStart;
                string coords = decryptedMsg.Substring(coordsIndexStart+1, coordsLenght-1);
                Console.WriteLine($"Found {resource} at {coords}");
                sb.Clear();
            }
        }
    }
}
