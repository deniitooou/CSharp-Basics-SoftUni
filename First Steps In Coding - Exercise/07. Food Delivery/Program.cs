using System;

namespace FoodDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double chickenMenu = 10.35;
            double fishMenu = 12.40;
            double veganMenu = 8.15;
            double delivery = 2.50;
            double dessertProcent = 20;
            double procent = 100;

            double numChickenMenu = double.Parse(Console.ReadLine());
            double numFishMenu = double.Parse(Console.ReadLine());
            double numVeganMenu = double.Parse(Console.ReadLine());

            double sumChickenMenu = numChickenMenu * chickenMenu;
            double sumFishMenu = numFishMenu * fishMenu;
            double sumVeganMenu = numVeganMenu * veganMenu;
            double sum = sumChickenMenu + sumFishMenu + sumVeganMenu;
            double dessert = dessertProcent / procent;
            double sumDessert = sum * dessert;
            double amount = sum + sumDessert + delivery;

            Console.WriteLine(amount);
        }
    }
}