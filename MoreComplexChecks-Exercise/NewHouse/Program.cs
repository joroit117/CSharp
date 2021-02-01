using System;

namespace NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfFlowers = Console.ReadLine();
            int numberOfFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double priceFlowers = 0.0;

            switch(typeOfFlowers)
            {
                case "Roses":
                    priceFlowers = 5 * numberOfFlowers;
                    if(numberOfFlowers > 80)
                    {
                        priceFlowers -= 0.1 * priceFlowers;
                    }
                    break;
                case "Dahlias":
                    priceFlowers = 3.8 * numberOfFlowers;
                    if (numberOfFlowers > 90)
                    {
                        priceFlowers -= 0.15 * priceFlowers;
                    }
                    break;
                case "Tulips":
                    priceFlowers = 2.8 * numberOfFlowers;
                    if (numberOfFlowers > 80)
                    {
                        priceFlowers -= 0.15 * priceFlowers;
                    }
                    break;
                case "Narcissus":
                    priceFlowers = 3 * numberOfFlowers;
                    if (numberOfFlowers < 120)
                    {
                        priceFlowers += 0.15 * priceFlowers;
                    }
                    break;
                case "Gladiolus":
                    priceFlowers = 2.5 * numberOfFlowers;
                    if (numberOfFlowers < 80)
                    {
                        priceFlowers += 0.2 * priceFlowers;
                    }
                    break;
            }
            if(priceFlowers > budget)
            {
                Console.WriteLine($"Not enough money, you need {priceFlowers - budget:f2} leva more.");
            }
            else
            {
                Console.WriteLine($"Hey, you have a great garden with { numberOfFlowers } { typeOfFlowers } and {budget - priceFlowers:f2} leva left.");
            }
        }
    }
}
