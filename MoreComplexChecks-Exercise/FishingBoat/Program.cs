using System;

namespace FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermans = int.Parse(Console.ReadLine());
            double price = 0.0;

            if(season == "Spring")
            {
                price = 3000;
            }
            else if(season == "Summer" || season == "Autumn")
            {
                price = 4200;
            }
            else if(season == "Winter")
            {
                price = 2600;
            }

            if(fishermans <= 6)
            {
                price -= 0.1 * price;
            }
            else if(fishermans > 6 && fishermans <= 11)
            {
                price -= 0.15 * price;
            }
            else if(fishermans >= 12)
            {
                price -= 0.25 * price;
            }

            if(fishermans % 2 == 0 && season != "Autumn")
            {
                price -= 0.05 * price;
            }

            if(budget >= price)
            {
                Console.WriteLine($"Yes! You have {budget - price:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {price - budget:f2} leva.");
            }
        }
    }
}
