using System;

namespace ToyShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tripPrice = double.Parse(Console.ReadLine());
            int puzzleCount = int.Parse(Console.ReadLine());
            int dollsCount = int.Parse(Console.ReadLine());
            int teddyCount = int.Parse(Console.ReadLine());
            int minionCount = int.Parse(Console.ReadLine());
            int truckCount = int.Parse(Console.ReadLine());

            double puzzlePrice = puzzleCount * 2.60;
            double dollsPrice = dollsCount * 3;
            double teddyPrice = teddyCount * 4.10;
            double minionPrice = minionCount * 8.20;
            double truckPrice = truckCount * 2;

            double totalSum = puzzlePrice + dollsPrice + teddyPrice + minionPrice + truckPrice;
            int countTotal = puzzleCount + dollsCount + teddyCount + minionCount + truckCount;

            if (countTotal >= 50)
            {
                totalSum -= totalSum * 0.25;
            }

            totalSum -= totalSum * 0.1;

            double leftMoney = totalSum - tripPrice;
            double neededMoney = tripPrice - totalSum;

            if (totalSum >= tripPrice)
            {
                Console.WriteLine($"Yes! {leftMoney:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {neededMoney:f2} lv needed.");
            }
        }
    }
}