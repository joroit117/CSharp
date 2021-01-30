using System;

namespace GodzillaVsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int scripters = int.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());
            double decorSum = budget * 0.10;
            double scriptersSum = scripters * price;
            if(scripters > 150)
            {
                scriptersSum -= scriptersSum * 0.10;
            }
            double total = budget - scriptersSum - decorSum;
            if (budget >= decorSum + scriptersSum)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {total:f2} leva left.");
            }
            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {-total:f2} leva more.");
            }
        }
    }
}
