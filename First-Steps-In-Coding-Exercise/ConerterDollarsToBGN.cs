using System;

namespace ConerterDollarsToBGN
{
    class Program
    {
        static void Main(string[] args)
        {
            const double courseOfDollars = 1.79549;
            double usd = double.Parse(Console.ReadLine());
            double bgn = usd * courseOfDollars;
            Console.WriteLine($"{bgn:f2}");
        }
    }
}
