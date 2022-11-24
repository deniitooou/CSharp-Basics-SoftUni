using System;

namespace CircleAreaAndPerimeter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());

            double calculateArea = r * r * Math.PI;
            double calculateParameter = 2 * r * Math.PI;

            Console.WriteLine("{0:f2}", calculateArea);
            Console.WriteLine("{0:f2}", calculateParameter);
        }
    }
}