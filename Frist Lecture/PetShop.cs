using System;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            //const double price1 = 2.50;
            //const double price2 = 4;
            int dogs = int.Parse(Console.ReadLine());
            int neighbourDogs = int.Parse(Console.ReadLine());
            double sum = dogs * 2.5 + neighbourDogs * 4;
            Console.WriteLine($"{sum} lv.");
        }
    }
}
