using System;

namespace FlowerShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double magnolia = 3.25;
            double hyacinth = 4.00;
            double rose = 3.50;
            double cactus = 8.00;

            double tax = 5.00;
            double persent = 100.0;
            double taxPersent = tax / persent;

            int numberMagnolia = int.Parse(Console.ReadLine());
            int numberHyacinth = int.Parse(Console.ReadLine());
            int numberRose = int.Parse(Console.ReadLine());
            int numberCactus = int.Parse(Console.ReadLine());
            double gift = double.Parse(Console.ReadLine());

            double sum = numberMagnolia * magnolia + numberHyacinth * hyacinth + numberRose * rose + numberCactus * cactus;

            double taxes = sum * taxPersent;

            double money = sum - taxes;

            if (money >= gift)
            {
                Console.WriteLine("She is left with {0} leva.", Math.Truncate(money - gift));

            }
            else
            {
                Console.WriteLine("She will have to borrow {0} leva.", Math.Ceiling(gift - money));
            }
        }
    }
}