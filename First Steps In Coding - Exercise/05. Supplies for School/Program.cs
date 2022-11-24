using System;

namespace SuppliesForSchool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pens = 5.80;
            double markers = 7.20;
            double preparat = 1.20;

            double packsPens = double.Parse(Console.ReadLine());
            double packsMarkers = double.Parse(Console.ReadLine());
            double litres = double.Parse(Console.ReadLine());
            double procentDiscount = double.Parse(Console.ReadLine());

            double moneyPens = packsPens * pens;
            double moneyMarkers = packsMarkers * markers;
            double moneyPreparat = litres * preparat;

            double money = moneyPens + moneyMarkers + moneyPreparat;

            int procent = 100;
            double discount = money - (money * (procentDiscount / procent));

            Console.WriteLine(discount);
        }
    }
}