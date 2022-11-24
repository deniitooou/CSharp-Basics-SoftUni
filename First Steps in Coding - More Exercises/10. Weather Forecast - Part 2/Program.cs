using System;

namespace WeatherForecastPart2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double degree = double.Parse(Console.ReadLine());

            if (degree < 5 || degree > 35)
            {
                Console.WriteLine("unknown");
            }
            else if (degree >= 5 && degree < 12)
            {
                Console.WriteLine("Cold");
            }
            else if (degree < 15)
            {
                Console.WriteLine("Cool");
            }
            else if (degree <= 20)
            {
                Console.WriteLine("Mild");
            }
            else if (degree < 26)
            {
                Console.WriteLine("Warm");
            }
            else if (degree <= 35)
            {
                Console.WriteLine("Hot");
            }
        }
    }
}