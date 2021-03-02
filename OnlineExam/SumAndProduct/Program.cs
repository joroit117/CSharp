using System;

namespace SumAndProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int a = number % 10000;
            int b = number % 1000;
            int c = number % 100;
            int d = number % 10;

            Console.WriteLine(a);

        }
    }
}
