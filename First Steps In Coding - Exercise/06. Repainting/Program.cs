using System;

namespace Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nylon = 1.50;
            double paint = 14.50;
            double thinner = 5.00;
            double additionally = 2;
            double bag = 0.40;
            double procent = 100;
            double procentPaint = 10;
            double procentMasters = 30;

            double quantityNylon = double.Parse(Console.ReadLine());
            double quantityPaint = double.Parse(Console.ReadLine());
            double quantityThinner = double.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());

            double sumNylon = (quantityNylon + additionally) * nylon;
            double procentForPaint = quantityPaint / procentPaint;
            double sumPaint = (quantityPaint + procentForPaint) * paint;
            double sumThinner = quantityThinner * thinner;
            double amount = sumNylon + sumPaint + sumThinner + bag;
            double procentForMasters = procentMasters / procent;
            double sumMasters = (amount * procentForMasters) * hours;
            double finalAmount = amount + sumMasters;

            Console.WriteLine(finalAmount);
        }
    }
}