using System;

namespace Pets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double kilogram = 1000;

            int days = int.Parse(Console.ReadLine());
            int leftFoodKg = int.Parse(Console.ReadLine());
            double dailyDogFoodKg = double.Parse(Console.ReadLine());
            double dailyCatFoodKg = double.Parse(Console.ReadLine());
            double dailyTurtleFoodGrams = double.Parse(Console.ReadLine());

            double dog = days * dailyDogFoodKg;
            double cat = days * dailyCatFoodKg;
            double turtle = (days * dailyTurtleFoodGrams) / kilogram;

            double totalFood = Math.Ceiling(dog + cat + turtle);

            double difference = leftFoodKg - totalFood;

            if (totalFood <= leftFoodKg)
            {
                Console.WriteLine($"{difference} kilos of food left.");

            }
            else
            {
                Console.WriteLine($"{Math.Abs(difference)} more kilos of food are needed.");
            }
        }
    }
}