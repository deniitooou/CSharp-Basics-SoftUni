using System;

namespace TrainingLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine()) - 1;

            double rows = Math.Floor(width / 1.2);
            double columns = Math.Floor(length / 0.7);

            double total = rows * columns - 3;

            Console.WriteLine("{0:f0}", total);
        }
    }
}
