using System;

namespace WorldSwimmingRecord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timeSeconds = double.Parse(Console.ReadLine());

            int slowDown = 15;
            double slowDistance = 12.5;

            double swimming = distance * timeSeconds;
            double seconds = Math.Floor(distance / slowDown) * slowDistance;
            double time = swimming + seconds;


            if (record > time)
            {
                Console.WriteLine($" Yes, he succeeded! The new world record is {time:F2} seconds.");
            }
            else
            {
                double notEnough = time - record;
                Console.WriteLine($"No, he failed! He was {notEnough:F2} seconds slower.");
            }
        }

    }
}