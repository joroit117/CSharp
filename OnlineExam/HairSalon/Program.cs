using System;

namespace HairSalon
{
    class Program
    {
        static void Main(string[] args)
        {
            int aimedMoney = int.Parse(Console.ReadLine());
            double money = 0;

            while(true)
            {
                string service = Console.ReadLine();
                if(service == "closed")
                {
                    break;
                }
                else
                {
                    if (service == "haircut")
                    {
                        string typeOfHaircut = Console.ReadLine();
                        switch (typeOfHaircut)
                        {
                            case "mens":
                                money += 15;
                                break;
                            case "ladies":
                                money += 20;
                                break;
                            case "kids":
                                money += 10;
                                break;
                        }
                    }
                    else if(service == "color")
                    {
                        string typeOfColor = Console.ReadLine();
                        switch (typeOfColor)
                        {
                            case "touch up":
                                money += 20;
                                break;
                            case "full color":
                                money += 30;
                                break;
                        }
                    }
                }
                if(money >= aimedMoney)
                {
                    break;
                }
            }
            if(money >= aimedMoney)
            {
                Console.WriteLine("You have reached your target for the day!");
            }
            else
            {
                Console.WriteLine($"Target not reached! You need {aimedMoney - money}lv. more.");
            }
            Console.WriteLine($"Earned money: {money}lv.");
        }
    }
}
