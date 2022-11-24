using System;

namespace PetShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dog = int.Parse(Console.ReadLine());
            int cat = int.Parse(Console.ReadLine());

            double dogs = dog * 2.50;
            double cats = cat * 4;
            double together = dogs + cats;

            Console.WriteLine($"{together} lv.");
        }
    }
}