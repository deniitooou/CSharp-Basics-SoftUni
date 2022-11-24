using System;

namespace FuelTankPart2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double gasoline = 2.22;
            double diesel = 2.33;
            double gas = 0.93;

            double cardGasoline = 0.18;
            double cardDiesel = 0.12;
            double cardGas = 0.08;

            double discount = 0.00;
            double persent = 100.0;
            double lowDiscount = 8.0;
            double bigDiscount = 10.0;

            string type = Console.ReadLine().ToLower();
            double quantity = double.Parse(Console.ReadLine());
            string cart = Console.ReadLine().ToLower();

            if (cart == "yes")
            {
                gasoline -= cardGasoline;
                diesel -= cardDiesel;
                gas -= cardGas;
            }
            if (quantity >= 20 && quantity <= 25)
            {
                discount = lowDiscount / persent;
            }

            if (quantity > 25)
            {
                discount = bigDiscount / persent;
            }
            if (type == "gas")
            {
                double total = quantity * gas;
                double sum = total - (total * discount);
                Console.WriteLine($"{sum:f2} lv.");
            }
            else if (type == "diesel")
            {
                double total = quantity * diesel;
                double sum = total - (total * discount);
                Console.WriteLine($"{sum:f2} lv.");
            }
            else if (type == "gasoline")
            {
                double total = quantity * gasoline;
                double sum = total - (total * discount);
                Console.WriteLine($"{sum:f2} lv.");
            }
        }
    }
}