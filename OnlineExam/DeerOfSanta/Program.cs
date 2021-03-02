using System;

namespace DeerOfSanta
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int foodLeft = int.Parse(Console.ReadLine());
            double foodDeer1 = double.Parse(Console.ReadLine());
            double foodDeer2 = double.Parse(Console.ReadLine());
            double foodDeer3 = double.Parse(Console.ReadLine());

            double foodNeeded = (foodDeer1 + foodDeer2 + foodDeer3) * days;

            if(foodNeeded <= foodLeft)
            {
                double moreFood = Math.Floor(foodLeft - foodNeeded);
                Console.WriteLine($"{moreFood} kilos of food left.");
            }
            else
            {
                double lessFood = Math.Ceiling(foodNeeded - foodLeft);
                Console.WriteLine($"{lessFood} more kilos of food are needed.");
            }
        }
    }
}
