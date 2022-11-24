using System;

namespace TimePlus15Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var hour = int.Parse(Console.ReadLine());
            var min = int.Parse(Console.ReadLine());

            var time = ((hour * 60) + min + 15);
            var resultHour = time / 60;

            if (resultHour >= 24)
            {
                resultHour -= 24;
            }

            var resultMin = time % 60;

            Console.WriteLine("{0}:{1:00}", resultHour, resultMin);
        }
    }
}