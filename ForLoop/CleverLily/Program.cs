using System;

namespace CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double priceWashingMachine = double.Parse(Console.ReadLine());
            double priceToys = double.Parse(Console.ReadLine());

            int toysCount = 0;
            double savedMoney = 0;
            double moneyGift = 10;

            for(int i = 1; i <= age; i++)
            {
                if(i % 2 == 0)
                {
                    savedMoney += moneyGift;
                    savedMoney--;

                    moneyGift += 10;
                }
                else
                {
                    toysCount++;
                }
            }
            double moneyFromToys = toysCount * priceToys;
            savedMoney += moneyFromToys;

            if(savedMoney >= priceWashingMachine)
            {
                Console.WriteLine($"Yes! {savedMoney - priceWashingMachine:f2}");
            }
            else
            {
                Console.WriteLine($"No! {priceWashingMachine - savedMoney:f2}");
            }
        }
    }
}
