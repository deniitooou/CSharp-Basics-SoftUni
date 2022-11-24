using System;

namespace HousePainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
			double greenMetres = 3.4;
			double redMetres = 4.3;

			double x = double.Parse(Console.ReadLine());
			double y = double.Parse(Console.ReadLine());
			double h = double.Parse(Console.ReadLine());

			double greenArea = 2 * (x * x) + 2 * (x * y) - 6.9;
			double redArea = x * h + 2 * x * y;
			double greenPaint = greenArea / greenMetres;
			double redPaint = redArea / redMetres;

			Console.WriteLine("{0:f2}", greenPaint);
			Console.WriteLine("{0:f2}", redPaint);
		}
    }
}
