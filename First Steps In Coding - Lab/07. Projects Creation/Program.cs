using System;

namespace ProjectsCreation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int projects = int.Parse(Console.ReadLine());

            int work = projects * 3;

            Console.WriteLine($"The architect {name} will need {work} hours to complete {projects} project/s.");
        }
    }
}