using System;

namespace USDtoBGN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double usdToBgn = 1.79549;

            double usd = double.Parse(Console.ReadLine());

            double bgnResult = usd * usdToBgn;

            Console.WriteLine(bgnResult);
        }
    }
}