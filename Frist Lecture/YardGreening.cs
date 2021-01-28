using System;

namespace YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pricePerSM = 7.61;
            const double discount = 0.18;
            double squareMeters = double.Parse(Console.ReadLine());
            double dis = pricePerSM * squareMeters * discount;
            double finalPrice = pricePerSM * squareMeters - dis;
            Console.WriteLine($"The final price is: {finalPrice} lv.");
            Console.WriteLine($"The discount is: {dis} lv.");
        }
    }
}
