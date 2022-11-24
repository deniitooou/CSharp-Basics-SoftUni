using System;

namespace Fishland
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double musselsPrice = 7.50;
            double mackerelPrice = double.Parse(Console.ReadLine());
            double spratPrice = double.Parse(Console.ReadLine());

            double bonitoKilograms = double.Parse(Console.ReadLine());
            double safridKilograms = double.Parse(Console.ReadLine());
            double musselsKilograms = double.Parse(Console.ReadLine());

            double bonitoPrice = 1.6 * mackerelPrice;
            double safridPrice = 1.8 * spratPrice;

            double totalPrice = bonitoPrice * bonitoKilograms + safridPrice * safridKilograms + musselsPrice * musselsKilograms;
            Console.WriteLine("{0:f2}", totalPrice);
        }
    }
}