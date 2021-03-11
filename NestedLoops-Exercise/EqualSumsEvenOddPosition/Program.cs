using System;

namespace EqualSumsEvenOddPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            for(int i = number1; i <= number2; i++)
            {
                string current = i.ToString();
                int oddSum = 0;
                int evenSum = 0;
                for(int j = 0; j < current.Length; j++)
                {
                    if(j % 2 == 0)
                    {
                        evenSum += int.Parse(current[j].ToString());
                    }
                    else
                    {
                        oddSum += int.Parse(current[j].ToString());
                    }
                }
                if(evenSum == oddSum)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
