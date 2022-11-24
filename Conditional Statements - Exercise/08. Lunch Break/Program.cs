using System;

namespace LunchBreak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double timeForLunch = 8;
            double timeForRest = 4;

            string name = Console.ReadLine();
            int durationEpisode = int.Parse(Console.ReadLine());
            int durationBreak = int.Parse(Console.ReadLine());

            double timeLunch = durationBreak / timeForLunch;
            double timeRest = durationBreak / timeForRest;
            double timeLeft = durationBreak - timeLunch - timeRest;

            double leftTime = Math.Abs(durationEpisode - timeLeft);

            if (timeLeft >= durationEpisode)
            {
                Console.WriteLine($"You have enough time to watch {name} and left with {Math.Ceiling(leftTime)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {name}, you need {Math.Ceiling(leftTime)} more minutes.");
            }
        }
    }
}