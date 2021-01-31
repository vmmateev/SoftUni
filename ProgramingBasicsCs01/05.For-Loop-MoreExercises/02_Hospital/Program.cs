using System;

namespace _02_Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            double period = double.Parse(Console.ReadLine());
            double treatedPatient = 0;
            double untreatedPatient = 0;
            double additionalDoctor = 0;
            for (int i = 1; i <= period; i++)
            {
                double patient = double.Parse(Console.ReadLine());
                if (i % 3 == 0 && untreatedPatient > treatedPatient)
                {
                    additionalDoctor++;
                }
                
                if (patient >= 7+additionalDoctor)
                {
                    treatedPatient = treatedPatient + 7 + additionalDoctor;
                    untreatedPatient += (patient - 7 - additionalDoctor);
                }
                else
                {
                    treatedPatient = treatedPatient + patient;
                }
            }
            Console.WriteLine($"Treated patients: {treatedPatient}.");
            Console.WriteLine($"Untreated patients: {untreatedPatient}.");
        }
    }
}
