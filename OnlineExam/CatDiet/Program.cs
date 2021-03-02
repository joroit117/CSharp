using System;

namespace CatDiet
{
    class Program
    {
        static void Main(string[] args)
        {
            double fatsPercentage = double.Parse(Console.ReadLine());
            double proteinPercentage = double.Parse(Console.ReadLine());
            double carbsPercentage = double.Parse(Console.ReadLine());
            double caloriesTotal = double.Parse(Console.ReadLine());
            double waterPercentage = double.Parse(Console.ReadLine());

            double fats = (fatsPercentage / 100 * caloriesTotal) / 9;
            double proteins = (proteinPercentage / 100 * caloriesTotal) / 4;
            double carbs = (carbsPercentage / 100 * caloriesTotal) / 4;
            double foodInGrams = fats + proteins + carbs;

            double caloriesPerGramFood = caloriesTotal / foodInGrams;

            double calories = (100 - waterPercentage) / 100 * caloriesPerGramFood;

            Console.WriteLine($"{calories:f4}");
        }
    }
}
