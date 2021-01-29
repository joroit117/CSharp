using System;

namespace ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double tripPrice = double.Parse(Console.ReadLine());
            int numberOfPuzzles = int.Parse(Console.ReadLine());
            int numberOfTalkingDolls = int.Parse(Console.ReadLine());
            int numberOfTeddyBears = int.Parse(Console.ReadLine());
            int numberOfMinions = int.Parse(Console.ReadLine());
            int numberOfTrucks = int.Parse(Console.ReadLine());
            double money = 0;
            money = numberOfPuzzles * 2.6 + numberOfTalkingDolls * 3 + numberOfTeddyBears * 4.1 +
                numberOfMinions * 8.2 + numberOfTrucks * 2;
            money -= 0.1 * money;
            if((numberOfPuzzles + numberOfTalkingDolls + numberOfTeddyBears + numberOfMinions + numberOfTrucks) >= 50)
            {
                money -= 0.25 * money;
            }
            if(money >= tripPrice)
            {
                Console.WriteLine($"Yes! {money - tripPrice:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {tripPrice - money:f2} lv needed.");
            }
        }
    }
}
