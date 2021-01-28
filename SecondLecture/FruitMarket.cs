using System;

namespace FruitMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceStrawberries = double.Parse(Console.ReadLine());
            double bananas = double.Parse(Console.ReadLine());
            double oranges = double.Parse(Console.ReadLine());
            double raspberries = double.Parse(Console.ReadLine());
            double strawberies = double.Parse(Console.ReadLine());
            double priceRaspberries = priceStrawberries / 2;
            double priceOranges = priceRaspberries - 0.4 * priceRaspberries;
            double priceBananas = priceRaspberries - 0.8 * priceRaspberries;
            double sum = strawberies * priceStrawberries + raspberries * priceRaspberries + bananas * priceBananas + oranges * priceOranges;
            Console.WriteLine($"{sum:f2}");

        }
    }
}
