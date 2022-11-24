using System;

namespace SleepyTomCat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int norm = 30000;
            int workDayMinutes = 63;
            int dayOffMinutes = 127;
            int yearDays = 365;
            int hour = 60;

            int numberDaysOff = int.Parse(Console.ReadLine());

            int daysOff = numberDaysOff * dayOffMinutes;
            int workDay = (yearDays - numberDaysOff) * workDayMinutes;

            int workDays = yearDays - numberDaysOff;
            int timeGaming = (workDays * workDayMinutes) + (numberDaysOff * dayOffMinutes);

            if (norm > timeGaming)
            {
                int enough = norm - timeGaming;
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{enough / hour} hours and { enough % hour} minutes less for play");
            }
            else
            {
                int notEnough = timeGaming - norm;
                Console.WriteLine($"Tom will run away");
                Console.WriteLine($"{notEnough / hour} hours and {notEnough % hour} minutes more for play");
            }
        }
    }
}