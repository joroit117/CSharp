using System;

namespace CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            const double cake = 45;
            const double waffle = 5.8;
            const double pancake = 3.2;
            int days = int.Parse(Console.ReadLine());
            int bakers = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int waffles = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());
            double sumPerDay = (cake * cakes + waffle * waffles + pancake * pancakes) * bakers;
            double wholeSum = sumPerDay * days;
            double wholeSumTax = wholeSum - wholeSum / 8;
            Console.WriteLine(wholeSumTax);
        }
    }
}