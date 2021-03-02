using System;

namespace MiningRig
{
    class Program
    {
        static void Main(string[] args)
        {
            int videoCardPrice = int.Parse(Console.ReadLine());
            int adapterPrice = int.Parse(Console.ReadLine());
            double currentPriceVCPerDay = double.Parse(Console.ReadLine());
            double earningsVCPerDay = double.Parse(Console.ReadLine());

            int endPriceVideoCards = 13 * videoCardPrice;
            int endPriceAdapters = 13 * adapterPrice;
            int endPriceAll = 1000 + endPriceVideoCards + endPriceAdapters;

            double earningsPerDayOneVC = earningsVCPerDay - currentPriceVCPerDay;
            double earningsTotalPerDay = earningsPerDayOneVC * 13;

            double daysReturnInvestment = endPriceAll / earningsTotalPerDay;

            Console.WriteLine(endPriceAll);
            Console.WriteLine(Math.Ceiling(daysReturnInvestment));
        }
    }
}
