using System;

namespace SumAndProduct1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            int a = rnd.Next(1, 9);
            int b = rnd.Next(a, 9);
            int c = rnd.Next(0, 9);
            int d = rnd.Next(c, 9);
            int k = (a * b * c * d) / (a + b + c + d);

            if (a + b + c + d == a * b * c * d && number % 10 == 5)
            {
                int n = a * 1000 + b * 100 + c * 10 + d;
                Console.WriteLine(n);
            }
            
           else if(k == 3 && number % 3 == 0)
            {
                int n = d * 1000 + c * 100 + b * 10 + a;
                Console.WriteLine(n);
            }
            else
            {
                Console.WriteLine("Nothing found");
            }
        }
    }
}
