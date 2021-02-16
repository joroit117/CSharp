using System;

namespace SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int comboCounter = 0;
            bool foundCombo = false;

            for(int i = startNumber; i <= endNumber; i++)
                for (int j = startNumber; j <= endNumber; j++)
                {
                    comboCounter++;
                    if(i + j == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{comboCounter} ({i} + {j} = {magicNumber})");
                        foundCombo = true;
                        i = endNumber;
                        j = endNumber;
                    }
                }
            if(foundCombo == false)
            {
                Console.WriteLine($"{comboCounter} combinations - neither equals {magicNumber}");
            }
        }
    }
}
