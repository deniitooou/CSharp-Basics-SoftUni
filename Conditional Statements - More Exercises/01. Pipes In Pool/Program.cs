using System;

namespace PipesInPool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int percent = 100;

            int volume = int.Parse(Console.ReadLine());
            int pipe1 = int.Parse(Console.ReadLine());
            int pipe2 = int.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());

            double pipe1Liters = hours * pipe1;
            double pipe2Liters = hours * pipe2;
            double pipesLiters = pipe1Liters + pipe2Liters;

            double waterHours = hours / pipesLiters;

            if (pipesLiters <= volume)
            {
                double waterPersent = (pipesLiters / volume) * 100;
                double pipe1Persent = (pipe1 * waterHours) * percent;
                double pipe2Persent = (pipe2 * waterHours) * percent;

                Console.WriteLine($"The pools is {waterPersent:F2}% full. Pipe 1: {pipe1Persent:F2}%. Pipe 2: {pipe2Persent:F2}%.");
            }
            else
            {
                double moreWater = pipesLiters - volume;

                Console.WriteLine($"For {hours:F2} hours the pool overflows with {moreWater:F2} liters.");
            }
        }
    }
}