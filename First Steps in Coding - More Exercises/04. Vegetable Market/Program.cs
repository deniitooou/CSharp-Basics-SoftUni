using System;

namespace Vegetable_Market
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double euroToBgn = 1.94;

            double vegetablesPrice = double.Parse(Console.ReadLine());
            double fruitsPrice = double.Parse(Console.ReadLine());
            int vegetablesKilograms = int.Parse(Console.ReadLine());
            int fruitsKilograms = int.Parse(Console.ReadLine());

            double totalLeva = vegetablesKilograms * vegetablesPrice + fruitsKilograms * fruitsPrice;
            double totalEuro = totalLeva / euroToBgn;

            Console.WriteLine($"{totalEuro:f2}");
        }
    }
}
