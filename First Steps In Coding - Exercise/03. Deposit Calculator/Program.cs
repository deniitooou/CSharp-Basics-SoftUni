using System;

namespace DepositCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int yearInMonths = 12;

            double deposit = double.Parse(Console.ReadLine());
            double month = double.Parse(Console.ReadLine());
            double procent = double.Parse(Console.ReadLine());

            double interest = deposit * procent;
            double perMonth = interest / 100 / yearInMonths;
            double money = deposit + month * perMonth;

            Console.WriteLine(money);
        }
    }
}
