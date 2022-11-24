using System;

namespace AreaOfFigures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string form = Console.ReadLine();

            if (form == "square")
            {
                double squareSize = double.Parse(Console.ReadLine());
                double squareAnswer = squareSize * squareSize;
                Console.WriteLine($"{squareAnswer:f3}");
            }

            else if (form == "rectangle")
            {
                double rectangleSize = double.Parse(Console.ReadLine());
                double rectangleSize2 = double.Parse(Console.ReadLine());
                double rectangleAnswer = rectangleSize * rectangleSize2;
                Console.WriteLine($"{rectangleAnswer:f3}");
            }

            else if (form == "circle")
            {
                double circleRadius = double.Parse(Console.ReadLine());
                double circleAnswer = Math.PI * (circleRadius * circleRadius);
                Console.WriteLine($"{circleAnswer:f3}");
            }

            else if (form == "triangle")
            {
                double triangleSide = double.Parse(Console.ReadLine());
                double triangleHeight = double.Parse(Console.ReadLine());
                double circleAnswer = (triangleSide * triangleHeight) / 2;
                Console.WriteLine($"{circleAnswer:f3}");
            }
        }
    }
}