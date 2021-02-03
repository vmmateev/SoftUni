using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_Snowwhite
{
    class Program
    {
        static void Main(string[] args)
        {
            var dwarfDict = new Dictionary<string, int>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Once upon a time")
            {
                var tokens = input.Split(new char[] { ' ', ':', '<', '>' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                string nameColor = tokens[0] + ':' + tokens[1];
                int physics = int.Parse(tokens[2]);

                if (dwarfDict.ContainsKey(nameColor))
                {
                    if (dwarfDict[nameColor] < physics)
                    {
                        dwarfDict[nameColor] = physics;
                    }
                }
                else
                {
                    dwarfDict.Add(nameColor, physics);
                }
            }
                     // всяко джудже в речника сортиран по дес където хикс отива към стойноста , после по хикс отива към речника където y е сплитнато по : и се взима втората част която ако е равна на ключа сплитнат по : и се вземе пак втората час и да ги преброй колко такива са ОМГ
            foreach (var dwarf in dwarfDict.OrderByDescending(x => x.Value).ThenByDescending(x => dwarfDict.Where(y => y.Key.Split(':', 2)[1] == x.Key.Split(':', 2)[1]).Count()))
            {
                Console.WriteLine($"({dwarf.Key.Split(':',2)[1]}) {dwarf.Key.Split(':',2)[0]} <-> {dwarf.Value}");
            }

        }
    }
}
