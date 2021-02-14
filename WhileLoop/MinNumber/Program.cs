using System;

namespace MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int min = Int32.MaxValue;
            while (number != "Stop")
            {
                int num = int.Parse(number);
                if (num < min)
                {
                    min = num;
                }
                number = Console.ReadLine();
            }
            Console.WriteLine(min);
        }
    }
}
