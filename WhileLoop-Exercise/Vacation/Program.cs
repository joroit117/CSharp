using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyNeeded = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            int spendCounter = 0;
            int daysCounter = 0;
            bool imposible = false;

            while(budget < moneyNeeded)
            {
                if(spendCounter == 5)
                {
                    imposible = true;
                    break;
                }
                string action = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());
                if(action == "spend")
                {
                    spendCounter++;
                    if(budget - money < 0)
                    {
                        budget = 0;
                    }
                    else
                    {
                        budget -= money;
                    }
                }
                else if(action == "save")
                {
                    spendCounter = 0;
                    budget += money;
                }
                daysCounter++;
            }
            if(imposible)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(daysCounter);
            }
            else
            {
                Console.WriteLine($"You saved the money for {daysCounter} days.");
            }
        }
    }
}
