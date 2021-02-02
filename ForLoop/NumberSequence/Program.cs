using System;

namespace NumberSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int min = Int32.MaxValue;
            int max = Int32.MinValue;
            for(int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if(number > max)
                {
                    max = number;
                }
                if(number < min)
                {
                    min = number;
                }
            }
            Console.WriteLine($"Max number: {max}");
            Console.WriteLine($"Min number: {min}");
        }
    }
}
