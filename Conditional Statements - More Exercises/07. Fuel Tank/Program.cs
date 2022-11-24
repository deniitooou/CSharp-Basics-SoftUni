using System;

namespace FuelTank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fuelType = Console.ReadLine().ToLower();
            int level = int.Parse(Console.ReadLine());

            if (fuelType == "diesel" || fuelType == "gas" || fuelType == "gasoline")
            {
                if (level >= 25)
                {
                    Console.WriteLine($"You have enough {fuelType}.");
                }
                else
                {
                    Console.WriteLine($"Fill your tank with {fuelType}!");
                }
            }
            else
            {
                Console.WriteLine("Invalid fuel!");
            }

        }
    }
}