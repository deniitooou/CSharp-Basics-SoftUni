using System;

namespace TransportPrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double taxiStart = 0.70;
            double taxiDay = 0.79;
            double taxiNight = 0.90;
            double autobus = 0.09;
            double train = 0.06;

            var kilometers = int.Parse(Console.ReadLine());
            string dayTime = Console.ReadLine();
            var sum = 0.0;

            if (kilometers < 20)
            {
                if (dayTime == "day")
                {
                    sum = (kilometers * taxiDay) + taxiStart;
                }
                else
                {
                    sum = (kilometers * taxiNight) + taxiStart;
                }
            }
            else if (kilometers >= 20 && kilometers < 100)
            {
                sum = kilometers * autobus;
            }
            else if (kilometers >= 100 && kilometers <= 5000)
            {
                sum = kilometers * train;
            }

            Console.WriteLine($"{sum:f2}");
        }
    }
}