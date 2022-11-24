using System;

namespace InchesToCentimeters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double inch = double.Parse(Console.ReadLine());

            double cm = 2.54;
            double area = inch * cm;

            Console.WriteLine(area);
        }
    }
}