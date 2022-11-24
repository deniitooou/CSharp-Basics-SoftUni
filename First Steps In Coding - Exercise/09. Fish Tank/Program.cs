using System;

namespace FishTank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double occupiedSpaceProcent = 17;
            double hundred = 100;
            double thousand = 1000;
            double decimeter = 1;

            double lenght = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double procent = double.Parse(Console.ReadLine());

            double bulk = lenght * width * height;
            double bulkLitres = bulk / thousand;
            double occupiedSPaceProcent = procent / hundred;
            double litres = bulkLitres * (decimeter - occupiedSPaceProcent);

            Console.WriteLine(litres);
        }
    }
}