using System;

namespace MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int max = Int32.MinValue;
            while(number != "Stop")
            {
                int num = int.Parse(number);
                if(num > max)
                {
                    max = num;
                }
                number = Console.ReadLine();
            }
            Console.WriteLine(max);
        }
    }
}
