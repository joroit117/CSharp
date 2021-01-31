using System;

namespace SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysStay = int.Parse(Console.ReadLine());
            string typeOfRoom = Console.ReadLine();
            string rating = Console.ReadLine();
            double discount = 0;
            double price = 0;

            if(typeOfRoom == "room for one person")
            {
                discount = 0;
                price = 18;
            }
            else if(typeOfRoom == "apartment")
            {
                price = 25;
                if(daysStay < 10)
                {
                    discount = 0.3;
                }
                else if(daysStay >= 10 && daysStay <= 15)
                {
                    discount = 0.35;
                }
                else if(daysStay > 15)
                {
                    discount = 0.5;
                }
            }
            else if(typeOfRoom == "president apartment")
            {
                price = 35;
                if (daysStay < 10)
                {
                    discount = 0.1;
                }
                else if (daysStay >= 10 && daysStay <= 15)
                {
                    discount = 0.15;
                }
                else if (daysStay > 15)
                {
                    discount = 0.2;
                }
            }
            double totalSum = (daysStay - 1) * price;
            totalSum -= totalSum * discount;
            if(rating == "positive")
            {
                totalSum += 0.25 * totalSum;
            }
            else if(rating == "negative")
            {
                totalSum -= 0.1 * totalSum;
            }
            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
