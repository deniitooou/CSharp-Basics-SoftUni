using System;

namespace Yard_Greening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 7.61;
            double discountProcent = 0.18;

            double metres = double.Parse(Console.ReadLine());

            double price = a * metres;
            double discount = discountProcent * price;
            double finalPrice = price - discount;

            Console.WriteLine($"The final price is:  {finalPrice} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}