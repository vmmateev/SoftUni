using System;

namespace _01_PipesInPool
{
    class Program
    {
        static void Main(string[] args)
        {
            double volumePool = double.Parse(Console.ReadLine());
            double firstPipeFlow = double.Parse(Console.ReadLine());
            double secondPipeFlow = double.Parse(Console.ReadLine());
            double time = double.Parse(Console.ReadLine());

            double firstPipeVolume = time * firstPipeFlow;
            double secondPipeVolume = time * secondPipeFlow;

            double filledVolume = firstPipeVolume + secondPipeVolume;
            double restVolumeOfPool = volumePool - filledVolume;
            if (restVolumeOfPool >= 0)
            {
                Console.WriteLine($"The pool is {(filledVolume / volumePool) * 100:f2}% full. Pipe 1: {(firstPipeVolume / filledVolume) * 100:f2}%. Pipe 2: {(secondPipeVolume / filledVolume) * 100:f2}%.");
            }
            else
            {
                Console.WriteLine($"For {time} hours the pool overflows with {Math.Abs(restVolumeOfPool):f2} liters.");
            }
        }

    }
}
