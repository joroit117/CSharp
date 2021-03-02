using System;

namespace PuppyCare
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogFoodKG = int.Parse(Console.ReadLine());
            int dogFoodGrams = dogFoodKG * 1000;
            string gramsFoodEatenPerDay = "";
            int totalFoodEaten = 0;

            while(gramsFoodEatenPerDay != "Adopted")
            {
                gramsFoodEatenPerDay = Console.ReadLine();
                if (gramsFoodEatenPerDay == "Adopted")
                {
                    break;
                }
                else
                {
                    int gramsFoodEatenPerDayN = int.Parse(gramsFoodEatenPerDay);
                    totalFoodEaten += gramsFoodEatenPerDayN;
                }
            }
            if (totalFoodEaten <= dogFoodGrams)
            {
                Console.WriteLine($"Food is enough! Leftovers: {dogFoodGrams - totalFoodEaten} grams.");
            }
            else
            {
                Console.WriteLine($"Food is not enough. You need {totalFoodEaten - dogFoodGrams} grams more.");
            }

        }
    }
}
