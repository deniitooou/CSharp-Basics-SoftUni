using System;

namespace Harvest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double harvest = 40.0;
            double persent = 100.0;
            double harvestPersent = harvest / persent;

            double liter = 2.5;

            int area = int.Parse(Console.ReadLine());
            double grapeSquare = double.Parse(Console.ReadLine());
            int liters = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());

            double grape = area * grapeSquare;
            double wine = (harvestPersent * grape) / liter;

            if (wine >= liters)
            {
                double wineLeft = wine - liters;
                double restWine = wineLeft / workers;

                Console.WriteLine($"Good harvest this year! Total wine: { Math.Floor(wine)} liters.");
                Console.WriteLine($"{ Math.Ceiling(wineLeft)} liters left -> { Math.Ceiling(restWine)} liters per person.");
            }
            else
            {
                double neededWine = liters - wine;

                Console.WriteLine($"It will be a tough winter! More { Math.Floor(neededWine)} liters wine needed.");
            }
        }
    }
}