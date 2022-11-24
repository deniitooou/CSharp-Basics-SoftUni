using System;

namespace Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int videoCards = int.Parse(Console.ReadLine());
            int processors = int.Parse(Console.ReadLine());
            int ram = int.Parse(Console.ReadLine());

            double percent = 100;
            double percentProcesor = 35;
            double percentRam = 10;
            double numberVideoCards = 15;

            double discountVideoCards = numberVideoCards / percent;

            double discountProcesor = percentProcesor / percent;
            double discountRam = percentRam / percent;

            double videocardsPrice = 250;

            double totalVideocardPrice = videoCards * videocardsPrice;

            double ProcessorsPrice = totalVideocardPrice * discountProcesor;
            double totalProcessorsPrice = processors * ProcessorsPrice;

            double RamPrice = totalVideocardPrice * discountRam;
            double totalRamPrice = ram * RamPrice;

            double finalSum = totalVideocardPrice + totalProcessorsPrice + totalRamPrice;
            double discount = 0;

            if (videoCards > processors)
            {
                discount = finalSum * discountVideoCards;
            }

            double finalDiscountSum = finalSum - discount;
            double moneyLeft = 0;

            if (finalSum <= budget)
            {
                moneyLeft = budget - finalDiscountSum;
                Console.WriteLine($"You have {moneyLeft:f2} leva left!");
            }
            else
            {
                moneyLeft = finalDiscountSum - budget;
                Console.WriteLine($"Not enough money! You need {moneyLeft:f2} leva more!");
            }
        }
    }
}