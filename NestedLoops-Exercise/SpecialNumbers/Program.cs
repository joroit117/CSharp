using System;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            
            for(int i = 1111; i <= 9999; i++)
            {
                int number = i;
                int d = number % 10;
                number /= 10;
                int c = number % 10;
                number /= 10;
                int b = number % 10;
                number /= 10;
                int a = number % 10;
                if(a == 0 || b == 0 || c == 0 || d == 0)
                {
                    continue;
                }
                else
                {
                    if (N % a == 0 && N % b == 0 && N % c == 0 && N % d == 0)
                    {
                        Console.Write(i + " ");
                    }
                }
            }
        }
    }
}
