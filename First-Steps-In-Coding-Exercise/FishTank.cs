using System;

namespace FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int heigth = int.Parse(Console.ReadLine());
            double percentages = double.Parse(Console.ReadLine());
            double liters = length * width * heigth * 0.001;
            percentages = percentages * 0.01;
            double neededLiters = liters * (1 - percentages);
            Console.WriteLine(neededLiters);
        }
    }
}
