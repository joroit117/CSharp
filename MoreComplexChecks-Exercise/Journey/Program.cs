using System;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string destination = "";
            double moneySpent = 0.0;
            string type = "";

            if(budget <= 100)
            {
                destination = "Bulgaria";
                if(season == "summer")
                {
                    type = "Camp";
                    moneySpent = 0.3 * budget;
                }
                else if(season == "winter")
                {
                    type = "Hotel";
                    moneySpent = 0.7 * budget;
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    type = "Camp";
                    moneySpent = 0.4 * budget;
                }
                else if (season == "winter")
                {
                    type = "Hotel";
                    moneySpent = 0.8 * budget;
                }
            }
            else if (budget > 1000)
            {
                type = "Hotel";
                destination = "Europe";
                moneySpent = 0.9 * budget;
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{type} - {moneySpent:f2}");
        }
    }
}
