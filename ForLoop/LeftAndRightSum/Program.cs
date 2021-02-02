using System;

namespace LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum1 = 0;
            int sum2 = 0;
            for(int i = 0; i < n*2; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if(i < n)
                {
                    sum1 += number;
                }
                else
                {
                    sum2 += number;
                }
            }
            if(sum1 == sum2)
            {
                Console.WriteLine($"Yes, sum = {sum1}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(sum1 - sum2)}");
            }
        }
    }
}
