using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace _08_CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, List<string>> companyList = new SortedDictionary<string, List<string>>();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] token = input.Split(" -> ");
                string company = token[0];
                string employeeID = token[1];
                if (companyList.ContainsKey(company))
                {
                    if (!companyList[company].Contains(employeeID))
                    {
                        companyList[company].Add(employeeID);
                    }
                }
                else
                {
                    companyList.Add(company, new List<string>() { employeeID });
                }
            }
            foreach (var employee in companyList)
            {
                Console.WriteLine(employee.Key);
                foreach (var id in employee.Value)
                {
                    Console.WriteLine($"-- {id}");
                }
            }
        }
    }
}
