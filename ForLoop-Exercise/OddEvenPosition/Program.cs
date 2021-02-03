using System;

namespace OddEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double OddSum = 0;
            double OddMin = Int32.MaxValue;
            double OddMax = Int32.MinValue;
            double EvenSum = 0;
            double EvenMin = Int32.MaxValue;
            double EvenMax = Int32.MinValue;
            for(int i = 1; i <= n; i++)
            {
                double number = double.Parse(Console.ReadLine());
                if(i % 2 == 0)
                {
                    EvenSum += number;
                    if(number < EvenMin)
                    {
                        EvenMin = number;
                    }
                    if(number > EvenMax)
                    {
                        EvenMax = number;
                    }
                }
                else
                {
                    OddSum += number;
                    if (number < OddMin)
                    {
                        OddMin = number;
                    }
                    if (number > OddMax)
                    {
                        OddMax = number;
                    }
                }
            }
            Console.WriteLine($"OddSum={OddSum:f2},");
            if(OddMin == Int32.MaxValue)
            {
                Console.WriteLine("OddMin=No,");
            }
            else
            {
                Console.WriteLine($"OddMin={OddMin:f2},");
            }
            if (OddMax == Int32.MinValue)
            {
                Console.WriteLine("OddMax=No,");
            }
            else
            {
                Console.WriteLine($"OddMax={OddMax:f2},");
            }
            Console.WriteLine($"EvenSum={EvenSum:f2},");
            if (EvenMin == Int32.MaxValue)
            {
                Console.WriteLine("EvenMin=No,");
            }
            else
            {
                Console.WriteLine($"EvenMin={EvenMin:f2},");
            }
            if (EvenMax == Int32.MinValue)
            {
                Console.WriteLine("EvenMax=No");
            }
            else
            {
                Console.WriteLine($"EvenMax={EvenMax:f2}");
            }

        }
    }
}
