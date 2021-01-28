using System;

namespace DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double depositSum = double.Parse(Console.ReadLine());
            int depositAmountPerMonth = int.Parse(Console.ReadLine());
            double interestPercentage = double.Parse(Console.ReadLine());
            double interestSum = depositSum * interestPercentage / 100;
            double sumOfInterests = interestSum / 12;
            double totalSum = depositSum + depositAmountPerMonth * sumOfInterests;
            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
