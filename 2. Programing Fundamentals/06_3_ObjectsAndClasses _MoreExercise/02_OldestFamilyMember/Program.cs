using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_OldestFamilyMember
{
    class Program
    {
        static void Main(string[] args)
        {
            var mana = new List<int>() { 1, 23, 4, 1, 23 }.Min();
            Console.WriteLine(mana);
        }
    }
}
