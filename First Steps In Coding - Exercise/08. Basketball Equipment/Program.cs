using System;

namespace BasketballEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sneakersProcent = 40;
            double procent = 100;
            double outFitProcent = 20;
            double ball = 4;
            double accessories = 5;

            double annualFee = double.Parse(Console.ReadLine());

            double discountSneakers = (sneakersProcent / procent) * annualFee;
            double sumSneakers = annualFee - discountSneakers;

            double discountOutFit = (outFitProcent / procent) * sumSneakers;
            double sumOutFit = sumSneakers - discountOutFit;

            double sumBall = sumOutFit / ball;
            double sumAccessories = sumBall / accessories;

            double amount = annualFee + sumSneakers + sumOutFit + sumBall + sumAccessories;
            Console.WriteLine(amount);
        }
    }
}